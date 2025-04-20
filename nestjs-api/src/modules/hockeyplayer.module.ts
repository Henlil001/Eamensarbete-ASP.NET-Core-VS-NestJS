import { Module } from '@nestjs/common';
import { TypeOrmModule } from '@nestjs/typeorm';
import { HockeyPlayerService } from '../services/hockeyplayer.service';
import { HockeyPlayerController } from '../controller/hockeyplayer.controllers';
import { HockeyPlayers } from '../types/entities/hockeyplayer.entity';
import { AutomapperModule } from '@automapper/nestjs';
import { classes } from '@automapper/classes';
import { AddPlayerProfile } from '../types/profile/addplayer.profile';
import { Nation } from '../types/entities/nation.entity';

@Module({
  imports: [
    AutomapperModule.forRoot({
      strategyInitializer: classes(),
    }),
    TypeOrmModule.forFeature([HockeyPlayers, Nation]),
  ],
  providers: [
    HockeyPlayerService,
    AddPlayerProfile,
    HockeyPlayers,
    Nation
  ],
  controllers: [HockeyPlayerController],
  exports: [HockeyPlayerService],
})
export class HockeyPlayerModule {}
