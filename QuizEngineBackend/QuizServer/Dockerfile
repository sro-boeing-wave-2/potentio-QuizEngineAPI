FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 44348

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /QuizServer
COPY *.csproj ./
RUN dotnet restore
COPY . .

WORKDIR /QuizServer
RUN dotnet build QuizServer.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish QuizServer.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "QuizServer.dll"]
