import { AutoMap } from '@automapper/classes';

export class AddplayerDto {
  @AutoMap()
  fullName: string;

  @AutoMap()
  hightInCm: number;

  @AutoMap()
  weightInKg: number;

  @AutoMap()
  club: string;

  @AutoMap()
  position: string;

  @AutoMap()
  age: number;

  @AutoMap()
  nationId: number;
}
