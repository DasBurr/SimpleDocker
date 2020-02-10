FROM postgres
WORKDIR /src
COPY . .
ENV POSTGRES_PASSWORD=password POSTGRES_DB=MovieApi
COPY create-db.sh .
CMD [ "create-db.sh" ] 