import {
  Entity,
  PrimaryGeneratedColumn,
  Column,
  OneToMany,
  JoinColumn,
} from 'typeorm';
import { HockeyPlayers } from './hockeyplayer.entity';

@Entity('Nations')
export class Nation {
  @PrimaryGeneratedColumn()
  id: number;

  @Column()
  nationality: string;

  @OneToMany(() => HockeyPlayers, (hockeyPlayer) => hockeyPlayer.nation)
  hockeyPlayers: HockeyPlayers[];
}
