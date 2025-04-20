import { Injectable, NestMiddleware } from '@nestjs/common';
import { Request, Response, NextFunction } from 'express';

@Injectable()
export class BasicAuthMiddleware implements NestMiddleware {
  use(req: Request, res: Response, next: NextFunction) {
    try {
      try {
        if (!req.header('authorization')) {
          this.unauthorized(res);
          return;
        }

        const authHeader = req.header('authorization');
        if (!authHeader || !authHeader.startsWith('Basic ')) {
          return this.unauthorized(res);
        }

        const encodedCreds = authHeader.substring(6);
        const decodedCreds = Buffer.from(encodedCreds, 'base64').toString(
          'utf-8',
        );

        const [username, password] = decodedCreds.split(':');

        if (!username || !password) {
          return this.unauthorized(res);
        }

        const validUsername = process.env.BASIC_AUTH_USERNAME;
        const validPassword = process.env.BASIC_AUTH_PASSWORD;

        if (username !== validUsername || password !== validPassword) {
          return this.unauthorized(res);
        }
      } catch {
        return this.unauthorized(res);
      }

      next();
    } catch {
      res.status(500).send('Internal Server Error');
    }
  }
  private unauthorized(res: Response) {
    res.status(401).send('Unauthorized');
  }
}
