# Trabalho Prático de Algoritmos e Estruturas de Dados - Universidade Stark

## Descrição

Este trabalho prático te coloca na pele de um desenvolvedor que precisa criar um sistema para gerenciar o processo seletivo da Universidade Stark. Você irá aplicar os conhecimentos de estruturas de dados e algoritmos aprendidos em sala de aula para construir um programa funcional que atenda às necessidades da universidade.

## Objetivo

* Consolidar e praticar os conceitos de estruturas de dados e algoritmos.
* Demonstrar domínio sobre listas, filas, algoritmos de ordenação e dicionários.
* Desenvolver habilidades de trabalho em equipe, dividindo as tarefas e garantindo que todos os membros compreendam o código.

## O Problema

A Universidade Stark possui cursos com vagas limitadas e filas de espera para os candidatos. A seleção dos candidatos se baseia na média das notas de Redação, Matemática e Linguagens, com critérios de desempate específicos. Cada candidato pode escolher duas opções de curso, e as regras de seleção são complexas:

1. **Primeira Opção:**  Candidato selecionado não entra na fila de espera.
2. **Segunda Opção:**  Candidato selecionado entra na fila de espera da primeira opção (se houver vaga).
3. **Nenhuma Opção:** Candidato entra na fila de espera de ambos os cursos (se houver vagas).
4. **Ambas as Opções:** Candidato é selecionado apenas para a primeira opção.

## O que você precisa fazer

1. **Criar um programa em C#** que lê dados de um arquivo de entrada (entrada.txt) e gera um arquivo de saída (saida.txt).
2. **Utilizar as seguintes estruturas de dados:**
    * **List:**  Para armazenar os candidatos selecionados de cada curso.
    * **Fila Linear:**  Para armazenar a fila de espera de cada curso. Você precisa implementar essa estrutura.
    * **Algoritmo de Ordenação:** Para organizar a lista de candidatos e a fila de espera em ordem decrescente de nota.
    * **Dicionário:**  Para armazenar os cursos.
3. **Processar os dados:** Calcular a média dos candidatos, aplicar os critérios de desempate, selecionar os candidatos para os cursos e organizar as listas de candidatos e filas de espera.
4. **Criar o arquivo de saída:**  Escrevendo informações como a nota de corte de cada curso, a lista de candidatos selecionados e a fila de espera.

## Estrutura do Código

* **Classes e Métodos:** Divida o código em classes para organizar as funcionalidades e métodos para realizar tarefas específicas.
* **Comentários:**  Embora a entrega não exija comentários, é importante que você documente seu código para facilitar a compreensão e a manutenção.

## Entrega e Avaliação

* **Entrega:** Um único membro do grupo entrega uma pasta compactada com o código fonte no Canvas.
* **Avaliação:**
    * **Entrevista Individual:** Perguntas sobre o código para avaliar o entendimento de todos os membros.
    * **Teste Automático:** Verificação da funcionalidade do programa através de testes automatizados.
    * **Boas Práticas:**  Avaliação da organização do código, nomes de variáveis e escolha de estruturas de dados.

## Pontos Importantes

* Todos os membros do grupo precisam entender o código completamente.
* Evite plágio. Trabalhos com plágio serão anulados.
* Organize-se e planeje o desenvolvimento para entregar um trabalho bem feito!

