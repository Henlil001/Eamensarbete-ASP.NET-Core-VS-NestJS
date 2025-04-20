import { AutoMap } from '@automapper/classes';
import { PrimaryGeneratedColumn } from 'typeorm';

export class UpdateplayerDto {
  id: number;

  fullName: string;

  hightInCm: number;

  weightInKg: number;

  club: string;

  position: string;

  age: number;

  nationId: number;
}
