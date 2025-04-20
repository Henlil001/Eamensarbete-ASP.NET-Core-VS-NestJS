import { MiddlewareConsumer, Module, NestModule } from '@nestjs/common';
import { TypeOrmModule } from '@nestjs/typeorm';
import { ConfigModule } from '@nestjs/config';
import { HockeyPlayerModule } from './modules/hockeyplayer.module'; // Import the feature module
import { HockeyPlayers } from './types/entities/hockeyplayer.entity';
import { BasicAuthMiddleware } from './Middleware/basicauth.middleware';
import { Nation } from './types/entities/nation.entity';

@Module({
  imports: [
    ConfigModule.forRoot(),
    TypeOrmModule.forRoot({
      type: 'mssql',
      host: process.env.DB_HOST,
      port: 1433,
      username: process.env.DB_USER,
      password: process.env.DB_PASSWORD,
      database: process.env.DB_NAME,
      entities: [HockeyPlayers, Nation],
      synchronize: false,
      options: {
        encrypt: true,
      }
    }),
    HockeyPlayerModule
  ],
})
export class AppModule implements NestModule {
  configure(consumer: MiddlewareConsumer) {
    consumer.apply(BasicAuthMiddleware).forRoutes('*');
  }
}
