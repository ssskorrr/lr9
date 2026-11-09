# Лабораторная работа №9 — Создание Docker-образа приложения

**Вариант Б: удалённая сборка с GitHub Actions**

## Проект

Минимальное веб-приложение на ASP.NET Core 10 (`Lab9Docker.csproj`).

## Проверка без Docker

```bash
dotnet publish -c Release -o ./publish
dotnet run
```

## Автоматическая сборка

При push в `main` или `master` workflow `.github/workflows/docker-build.yml` запускает `docker build -t test-app:latest .` на GitHub Actions (Ubuntu).

Откройте **Actions → Docker Build Test → build** и убедитесь, что шаг **Сборка Docker-образа в облаке GitHub** завершился успешно (зелёная галочка). Сделайте скриншот для отчёта.

## Дополнительное задание: Docker Compose

```bash
docker compose up --build
```

После запуска страница приложения будет доступна по адресу `http://localhost:8080`, проверка состояния — `http://localhost:8080/health`.
