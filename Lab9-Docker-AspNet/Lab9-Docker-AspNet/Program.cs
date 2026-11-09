var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content("""
<!doctype html>
<html lang="ru">
<head><meta charset="utf-8"><meta name="viewport" content="width=device-width, initial-scale=1"><title>ЛР №9 — Docker</title>
<style>body{font-family:system-ui,Arial;background:#0f172a;color:#e2e8f0;display:grid;place-items:center;min-height:100vh;margin:0}main{max-width:650px;margin:24px;padding:36px;background:#1e293b;border-radius:20px;box-shadow:0 12px 36px #0004}h1{color:#38bdf8}code{color:#86efac}</style>
</head><body><main><h1>Лабораторная работа №9</h1><h2>Создание Docker-образа приложения</h2><p>ASP.NET Core 10: приложение готово к контейнеризации.</p><p>Проверка: <code>GET /health</code></p><p>Вариант Б — сборка в GitHub Actions.</p></main></body></html>
""", "text/html; charset=utf-8"));
app.MapGet("/health", () => Results.Ok(new { status = "ok", application = "Lab9Docker" }));
app.Run();
