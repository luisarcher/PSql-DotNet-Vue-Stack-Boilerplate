FROM node:18-alpine

WORKDIR /app

# update and install dependency
# RUN apk update && apk upgrade
# RUN apk add git

# Install dependencies first, as they change less often than code.
COPY ./frontend/package.json .
COPY ./frontend/yarn.lock .

# RUN yarn install
RUN yarn install && yarn cache clean

COPY ./frontend/ ./

EXPOSE 3000

ENV NUXT_HOST=0.0.0.0
ENV NUXT_PORT=3000

ENV PATH ./node_modules/.bin/:$PATH

# ENTRYPOINT ["yarn", "dev"]