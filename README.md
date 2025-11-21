# 📚 A.C.E.S.S. - Accessible Competency Enhancement System & Support


## 👥 Autores

* **[Thais Leoncio]** - RM: 553892 
* **André de Sousa Neves** - RM: 553515

---

## 👨‍🏫 Módulo: Visão do Tutor (Backend C#)

![.NET Badge](https://img.shields.io/badge/.NET-8.0-purple)
![C# Badge](https://img.shields.io/badge/Language-C%23-green)
![Status Badge](https://img.shields.io/badge/Status-Em%20Desenvolvimento-yellow)

> "Empoderando tutores com dados acessíveis para potencializar o aprendizado inclusivo."

---

## 📋 Sobre o Projeto

O **A.C.E.S.S.** é uma solução integrada focada em acessibilidade e aprimoramento de competências. Este repositório contém o **Backend (API)** desenvolvido em C#, responsável pela **Visão do Tutor**.

Esta aplicação processa os dados coletados via **Mobile** (interação do aluno) e **IoT** (ambiente físico), centralizando as informações para que o tutor possa:
1. Monitorar o progresso dos alunos em tempo real.
2. Receber alertas de acessibilidade e adaptação ambiental.
3. Gerenciar trilhas de aprendizado personalizadas.

---

## 🚀 Funcionalidades Principais (Visão do Tutor)

Este serviço fornece endpoints para:

* **📊 Dashboard Analítico:** Consolidação de dados de desempenhoindividuais.
* **🔔 Gestão de Alertas:** Recebimento de notificações críticas vindas dos sensores IoT (ex: ruído excessivo, temperatura inadequada para o aluno).
* **👤 Perfil do Aluno:** CRUD completo dos alunos e suas necessidades específicas de acessibilidade.
* **📈 Relatórios de Competências:** Análise de gaps de competência baseada nos dados de uso do app mobile.
* **🤖 Integração IA (Opcional):** Sugestões de conteúdo baseadas no padrão de aprendizado (Generative AI).

---

## ⚙️ Como Executar o Projeto

### Pré-requisitos
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download) instalado.
* IDE (Visual Studio 2022 ou VS Code).
* Configuração da Connection String no `appsettings.json`.

### Passo a Passo

1.  **Clone o repositório:**
    ```bash
    git clone [INSIRA SEU LINK DO GITHUB AQUI]
    ```

2.  **Acesse a pasta do projeto:**
    ```bash
    cd Acess.Tutor.API
    ```

3.  **Restaure as dependências:**
    ```bash
    dotnet restore
    ```

4.  **Configure o Banco de Dados:**
    * Verifique a string de conexão no arquivo `appsettings.json`.
    * Execute as migrations (se estiver usando EF Core):
    ```bash
    dotnet ef database update
    ```

5.  **Execute a aplicação:**
    ```bash
    dotnet run
    ```

6.  **Acesse a Documentação (Swagger):**
    * Abra o navegador em: `http://localhost:5000/swagger` (ou a porta configurada).

---

## 📝 Licença

Este projeto foi desenvolvido para fins acadêmicos na **FIAP**.
