# 🖥️ A.C.E.S.S. Tutor Dashboard (WPF)

**Global Solution 2025.2 - Future at Work**

O **A.C.E.S.S. Tutor Dashboard** é uma aplicação Desktop desenvolvida em **C# (WPF)** para gestores e tutores de inclusão. Ele atua como a central de comando da plataforma A.C.E.S.S., permitindo o monitoramento em tempo real da fadiga e do desempenho de colaboradores com deficiência, utilizando Inteligência Artificial simulada para sugerir adaptações.

---

## 🎯 Objetivo e Propósito Social

Demonstrar como a tecnologia pode tornar o trabalho mais inclusivo e sustentável.  
O sistema permite que um tutor humano acompanhe múltiplos colaboradores PCDs, recebendo alertas de fadiga e sugestões de adaptação (ex: ativar comando de voz, aumentar contraste) baseadas em dados, garantindo a segurança e a autonomia do trabalhador.

---

## ⚙️ Arquitetura e POO (Pontos Chave)

O projeto foi construído seguindo rigorosos princípios de **Orientação a Objetos**:

### **Herança**
- **Classe Base Abstrata:** `Colaborador`  
  Define propriedades comuns como *Nome*, *ID* e *Fadiga*.
- **Classes Derivadas:**  
  `ColaboradorMotor` e `ColaboradorVisual`  
  Herdam de `Colaborador` e adicionam propriedades específicas.

### **Polimorfismo**
- O método abstrato `CalcularRecomendacaoIA()` é implementado de forma diferente em cada classe filha.
- O sistema trata todos como `Colaborador`, mas a execução da IA varia dinamicamente conforme o tipo de deficiência (Motor ou Visual).

---

## 🚀 Funcionalidades

- **Login Seguro:** Autenticação de tutores.  
- **Monitoramento em Tempo Real:** DataGrid interativo exibindo status da equipe.  
- **Simulação IoT:** Botão que simula a recepção de dados de telemetria (níveis de fadiga).  
- **Análise de IA:** Algoritmo que processa os dados e sugere intervenções específicas.

---

## 🛠 Tecnologias Utilizadas

- **Linguagem:** C# (.NET 6.0 / .NET Framework)  
- **Interface:** WPF com XAML  
- **Design Pattern:** Code Behind com Models separados  
- **IDE:** Visual Studio 2022  

---

## 📦 Como Executar

1. Abra o arquivo **AcessDashboard.sln** no Visual Studio.  
2. Certifique-se de que a carga de trabalho **"Desenvolvimento para desktop com .NET"** está instalada.  
3. Compile a solução: **Build > Build Solution**.  
4. Clique em **Iniciar (Start)**.

### 🔐 Login de Acesso
- **Usuário:** tutor  
- **Senha:** 123  

---

## 👥 Integrantes do Grupo

- Nome: **André de Souza Neves** – RM: **553515**  
- Nome: **Thaís Gonçalves Leoncio** – RM: **553892**  

---

Projeto desenvolvido para a disciplina de **C#**.
