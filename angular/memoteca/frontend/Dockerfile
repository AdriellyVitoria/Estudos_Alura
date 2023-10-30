# container de build
FROM node:latest AS build
WORKDIR /app
RUN npm cache clean --force
COPY . .
RUN npm install
RUN npm run build --prod

# container de execução
FROM nginx:latest AS run
COPY --from=build /app/dist/memoteca /usr/share/nginx/html
COPY /nginx.conf /etc/nginx/conf.d/default.conf
EXPOSE 80