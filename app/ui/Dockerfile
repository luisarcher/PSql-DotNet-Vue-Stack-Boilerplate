FROM node:18-alpine

WORKDIR /app

# update and install dependency
RUN apk update && apk upgrade
RUN apk add git

# Install dependencies first, as they change less often than code.
COPY ./frontend/package.json .
COPY ./frontend/package-lock.json .
RUN npm install

COPY ./frontend .

RUN npm run build

EXPOSE 3000

ENV NUXT_HOST=0.0.0.0
ENV NUXT_PORT=3000

CMD [ "npm", "run", "start" ]