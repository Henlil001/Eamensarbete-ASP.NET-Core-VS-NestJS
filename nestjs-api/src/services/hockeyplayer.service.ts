import { Injectable, Logger } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { HockeyPlayers } from '../types/entities/hockeyplayer.entity';
import { Repository, ILike } from 'typeorm';
import { AddplayerDto } from '../types/dto/addplayer.dto';
import { Mapper } from '@automapper/core';
import { InjectMapper } from '@automapper/nestjs';
import { UpdateplayerDto } from '../types/dto/updateplayer.dto';
import { Nation } from '../types/entities/nation.entity';

@Injectable()
export class HockeyPlayerService {
  private readonly logger = new Logger(HockeyPlayerService.name);
  constructor(
    @InjectRepository(HockeyPlayers)
    private readonly HockeyPlayerRepository: Repository<HockeyPlayers>,
    @InjectRepository(Nation)
    private readonly NationRepository: Repository<Nation>,
    @InjectMapper() private readonly classMapper: Mapper,
  ) {}

  async GetAllPlayersAsync(): Promise<HockeyPlayers[]> {
    const players = await this.HockeyPlayerRepository.find({
      order: { club: 'ASC' },
    });

    let totalAge = 0;
    let totalWeight = 0;

    // Simulerar ett steg av databearbetning
    for (const player of players) {
      totalAge += player.age;
      totalWeight += player.weightInKg;
    }
    const averageAge: number =
      players.length !== 0 ? totalAge / players.length : 0;
    const averageWeight: number =
      players.length !== 0 ? totalWeight / players.length : 0;

    this.logger.log(
      `GetAll: Total Age: ${totalAge}, AverageAge: ${averageAge}, Total Weight: ${totalWeight} AverageWeight: ${averageWeight}`,
    );

    return players;
  }
  async SearhPlayerAsync(searchVal: string): Promise<HockeyPlayers[]> {
    const results = await this.HockeyPlayerRepository.find({
      where: {
        fullName: ILike(`%${searchVal}%`),
      },
      relations: ['nation'],
      order: {
        nation: { nationality: 'ASC' },
      },
    });
    let totalAge = 0;
    let totalWeight = 0;

    // Simulerar ett steg av databearbetning
    for (const player of results) {
      totalAge += player.age;
      totalWeight += player.weightInKg;
    }
    const averageAge: number =
      results.length !== 0 ? totalAge / results.length : 0;
    const averageWeight: number =
      results.length !== 0 ? totalWeight / results.length : 0;

    this.logger.log(
      `Search: Total Age: ${totalAge}, Average Age: ${averageAge}, Total Weight: ${totalWeight} Average Weight: ${averageWeight}`,
    );

    return results;
  }
  async AddPlayerAsync(Player: AddplayerDto): Promise<void> {
    const playerToAdd = this.classMapper.map(
      Player,
      AddplayerDto,
      HockeyPlayers,
    );
    this.HockeyPlayerRepository.create(playerToAdd);
    await this.HockeyPlayerRepository.save(playerToAdd);
  }
  async UpdatePlayerAsync(player: UpdateplayerDto): Promise<boolean> {
    const playerToUpdate = await this.HockeyPlayerRepository.findOne({
      where: { id: player.id },
      relations: ['nation'],
    });

    if (!playerToUpdate) return false;

    if (player.nationId && player.nationId !== playerToUpdate.nation?.id) {
      const newNation = await this.NationRepository.findOneBy({
        id: player.nationId,
      });
      if (!newNation) {
        throw new Error('Invalid Nation ID');
      }
      playerToUpdate.nation = newNation;
    }
    Object.assign(playerToUpdate, player);

    await this.HockeyPlayerRepository.save(playerToUpdate);
    return true;
  }
  async DeletePlayerAsync(id: number): Promise<boolean> {
    const PlayerToDelete = await this.HockeyPlayerRepository.findOneBy({
      id: id,
    });
    if (PlayerToDelete) {
      await this.HockeyPlayerRepository.remove(PlayerToDelete);
      return true;
    } else {
      return false;
    }
  }
}
