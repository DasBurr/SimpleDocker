FROM postgres
COPY . .
ENV POSTGRES_PASSWORD=password POSTGRES_DB=MovieApi
ADD create-db.sh /docker-entrypoint-initdb.d