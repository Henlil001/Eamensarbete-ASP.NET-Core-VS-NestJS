import {
  Controller,
  Get,
  Put,
  Delete,
  Post,
  Param,
  Body,
  BadRequestException,
  HttpStatus,
} from '@nestjs/common';
import { HockeyPlayerService } from '../services/hockeyplayer.service';
import { HockeyPlayers } from '../types/entities/hockeyplayer.entity';
import { AddplayerDto } from '../types/dto/addplayer.dto';
import { UpdateplayerDto } from '../types/dto/updateplayer.dto';

@Controller('api/hockeyplayer')
export class HockeyPlayerController {
  constructor(private readonly HockeyPlayerService: HockeyPlayerService) {}

  @Get()
  async GetAllPlayersAsync(): Promise<{
    count: number;
    players: HockeyPlayers[];
  }> {
    const players = await this.HockeyPlayerService.GetAllPlayersAsync();
    return { count: players.length, players };
  }

  @Get(':searchVal')
  async SearhPlayerAsync(
    @Param('searchVal') searchVal,
  ): Promise<{ count: number; players: HockeyPlayers[] }> {
    const players = await this.HockeyPlayerService.SearhPlayerAsync(searchVal);
    return { count: players.length, players };
  }

  @Post()
  async AddPlayerAsync(@Body() player: AddplayerDto): Promise<string> {
    if (player.nationId < 1 || player.nationId > 6) {
      throw new BadRequestException('NationId most be between 1 and 6');
    }
    this.HockeyPlayerService.AddPlayerAsync(player);
    return 'player Added';
  }
  @Put()
  async UpdatePlayerAsync(@Body() player: UpdateplayerDto): Promise<string> {
    if (player.nationId < 1 || player.nationId > 6) {
      throw new BadRequestException('NationId most be between 1 and 6');
    }
    const check: boolean =
      await this.HockeyPlayerService.UpdatePlayerAsync(player);
    if (!check) {
      throw new BadRequestException(
        `player with ID: ${player.id} was not found`,
      );
    }
    return `player with ID: ${player.id} updated`;
  }
  @Delete(':id')
  async DeletePlayerAsync(@Param('id') id: number): Promise<string> {
    const check: boolean = await this.HockeyPlayerService.DeletePlayerAsync(id);
    if (!check) {
      return `player with ID: ${id} was not fond`;
    }
    return `player with ID: ${id} Deleted`;
  }
}
