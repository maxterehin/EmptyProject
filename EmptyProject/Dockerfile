FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 58733
EXPOSE 44393

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY EmptyProject/EmptyProject.csproj EmptyProject/
RUN dotnet restore EmptyProject/EmptyProject.csproj
COPY . .
WORKDIR /src/EmptyProject
RUN dotnet build EmptyProject.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish EmptyProject.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EmptyProject.dll"]
