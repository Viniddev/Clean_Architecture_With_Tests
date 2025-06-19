# Estudos sobre Clean Architecture + Unitary Test

![Badge Status](https://img.shields.io/badge/status-Finalizado-green)
![.NET](https://img.shields.io/badge/.NET-%3E%3D%206.0-blue)
![Licença](https://img.shields.io/badge/licen%C3%A7a-MIT-green)

Neste repositorio armazenei os documentos relacionados aos meus estudos sobre Arquitetura Limpa e Testes unitários com Xunit.

## 🤝 Contribuição

Sinta-se à vontade para contribuir com o projeto! Para isso:

1. Faça um fork do repositório
2. Crie uma branch (`git checkout -b minha-feature`)
3. Faça as mudanças necessárias
4. Commit suas alterações (`git commit -m 'Adicionando nova funcionalidade'`)
5. Faça um push para a branch (`git push origin minha-feature`)
6. Abra um Pull Request

## 🛠 Incluir migrations:
```bash
dotnet ef migrations add [MigrationName] -p .\App.Infrastructure\ -s .\App.Api\ --verbose
dotnet ef database update -p .\App.Infrastructure\ -s .\App.Api\ --verbose
```

## ❓ Adicione os user-secrets:
```bash
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=localhost,1433;Database=[YOUR_DB];User ID=sa;Password=[YOUR_PASSWORD];TrustServerCertificate=True;Encrypt=True;Trusted_Connection=True;"
dotnet user-secrets set "JwtKey" "[YOUR_JWT_KEY]"
```

## 📜 Licença

Este projeto está sob a licença MIT.

## 📞 Contato

Caso tenha dúvidas ou sugestões, entre em contato:

- **E-mail**: diasvinicius95@outlook.com
- **LinkedIn**: [linkedin.com/in/vinicius-dias-rodrigues/](https://www.linkedin.com/in/vinicius-dias-rodrigues/)
