import { AutoMap } from '@automapper/classes';
import {
  Entity,
  PrimaryGeneratedColumn,
  Column,
  ManyToOne,
  JoinColumn,
} from 'typeorm';
import { Nation } from './nation.entity';

@Entity('HockeyPlayers')
export class HockeyPlayers {
  @AutoMap()
  @PrimaryGeneratedColumn()
  id: number;

  @AutoMap()
  @Column()
  fullName: string;

  @AutoMap()
  @Column()
  hightInCm: number;

  @AutoMap()
  @Column()
  weightInKg: number;

  @AutoMap()
  @Column()
  club: string;

  @AutoMap()
  @Column()
  position: string;

  @AutoMap()
  @Column()
  age: number;

  @ManyToOne(() => Nation, (nation) => nation.hockeyPlayers)
  @JoinColumn({ name: 'nationId' }) 
  nation: Nation; 
}
