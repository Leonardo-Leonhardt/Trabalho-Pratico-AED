## Trabalho Prático - Sistema de Seleção da Universidade Stark

### Estrutura do Projeto

O projeto está organizado em pastas e arquivos:

- **src:** Contém o código-fonte do programa.
  - **Candidato.cs:** Define a classe Candidato, representando um candidato à Universidade Stark.
  - **Curso.cs:** Define a classe Curso, representando um curso oferecido pela universidade.
  - **SistemaSelecao.cs:** Classe principal do programa, responsável por ler os dados de entrada, processar a seleção e gerar a saída.
- **Entrada.txt:** Arquivo de entrada com os dados dos candidatos e cursos.
- **Saida.txt:** Arquivo de saída com a lista de candidatos selecionados e a fila de espera para cada curso.
- **Teste.cs:**  Classe de testes para verificar a funcionalidade do sistema.

### Classes Principais

#### Candidato

- **Atributos:** Nome, Nota Redação, Nota Matemática, Nota Linguagens, Opção 1, Opção 2.
- **Métodos:** Calcula a média das notas, retorna a opção de curso com maior nota, compara candidatos com base na média e nos critérios de desempate.

#### Curso

- **Atributos:** Nome, Vagas, Lista de candidatos selecionados, Fila de espera.
- **Métodos:** Seleciona candidatos com base na média e nas regras de seleção, organiza a fila de espera em ordem decrescente de nota.

#### SistemaSelecao

- **Atributos:** Dicionário de cursos, Lista de candidatos.
- **Métodos:** Lê dados do arquivo de entrada, processa a seleção de candidatos, gera o arquivo de saída.

### Algoritmos Utilizados

- **Ordenação:** O algoritmo de ordenação utilizado é o Bubble Sort, aplicado para ordenar a lista de candidatos e a fila de espera por ordem decrescente de nota.
- **Busca:** O algoritmo de busca utilizado é o linear, para encontrar o curso no dicionário de cursos.

### Instalação e Execução

1. **Baixar o repositório:** Baixe o repositório do GitHub.
2. **Abrir o projeto no Visual Studio:** Abra a solução do projeto no Visual Studio.
3. **Compilar e executar:** Compile o projeto e execute o programa.

### Arquivos de Entrada e Saída

- **Entrada.txt:** O arquivo de entrada contém os dados dos candidatos e cursos.
- **Saida.txt:** O arquivo de saída contém a lista de candidatos selecionados e a fila de espera para cada curso.

### Conclusão

Este projeto demonstra a aplicação de estruturas de dados e algoritmos para solucionar um problema real de gerenciamento de sistema de seleção. O código fonte é bem documentado e pode servir como base para projetos futuros.

### Contatos

Para dúvidas ou sugestões, entre em contato com [leonardoleonhardtbispo@gmail.com].
