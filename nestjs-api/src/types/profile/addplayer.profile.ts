import { Injectable } from '@nestjs/common';
import { AutomapperProfile, InjectMapper } from '@automapper/nestjs';
import { createMap, forMember, mapFrom, Mapper, MappingProfile } from '@automapper/core';
import { AddplayerDto } from '../dto/addplayer.dto';
import { HockeyPlayers } from '../entities/hockeyplayer.entity';
import { Nation } from '../entities/nation.entity';

@Injectable()
export class AddPlayerProfile extends AutomapperProfile {
  constructor(@InjectMapper() mapper: Mapper) {
    super(mapper);
  }
  override get profile(): MappingProfile {
    return (mapper) => {
      createMap(
        mapper,
        AddplayerDto,
        HockeyPlayers,
        forMember(
          (dest) => dest.nation,
          mapFrom((src) => ({ id: src.nationId }) as Nation), 
        ),
      );
    };
  }
}
