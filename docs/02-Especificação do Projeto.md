# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>
## Personas

| **Fernando Oliveira** |	**Administrador** |
|:---------------------:|:---------------|
|![Fernando Oliveira](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-1/blob/main/docs/img/Persona1.png)|Fernando é administrador de empresas e tem o cargo de Gerente Comercial em uma multinacional do ramo de alimentos. Está constantemente em viagens de negócios, em reuniões com clientes ou com as equipes de vendas. Fernando foi diagnosticado com hipertensão e precisa tomar um medicamento diariamente, na parte da manhã. Devido ao seu horário irregular de trabalho, frequentemente se esquece de tomar o medicamento. Com as frequentes viagens, também se esquece de levar o remédio e, não raro, tem dificuldade de encontrar uma farmácia próxima quando está em uma região que não conhece.|
| **Maria Antônia Souza** |	**Aposentada**|
|![Maria Antônia Souza](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-1/blob/main/docs/img/persona2.png)|Maria Antônia trabalhou de costureira durante muitos anos. Hoje tem 84 anos e é aposentada. Depois de muitos anos de trabalho, Maria Antônia foi diagnosticada com glaucoma, ceratocone, hipertensão e hipertireoidismo. Devido à idade avançada, esquece com facilidade seus horários e se já tomou os remédios, correndo grande risco de ingerir duas vezes o mesmo medicamento no mesmo horário. Com isso, precisa sempre da vigilância dos filhos para ajudá-la nesta tarefa árdua, inclusive na vigilância do estoque, na pesquisa de preços e na compra destes medicamentos.|
| **Gustavo Henrique** |	**Balconista de farmácia** |
|![Gustavo Henrique](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-1/blob/main/docs/img/persona3.jpg)|Gustavo é um balconista da Farmácia Mais Saúde. Todos os dias ele atende a diversas pessoas que procuram o estabelecimento para comprar os mais variados medicamentos. Ele acaba tendo algumas dificuldades com prescrições médicas ilegíveis ou de difícil compreensão.|
| **João e Maria** |	**Pais de família - Porteiro e Operadora de caixa** |
|![João e Maria](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-1/blob/main/docs/img/persona4.jpg)|Pais de família, com idade entre 30 e 35 anos.  A típica família brasileira, possui um alto custo de vida e despesas pesadas como alimentação, escola, transporte, financiamento, e ao final do mês pouco dinheiro é guardado para o lazer. João trabalha o dia inteiro como porteiro de um prédio, e Maria trabalha na padaria como operadora de caixa. As crianças ficam em uma creche escolar, e o período das escolas onde as crianças entram em contato com vários germes, demanda dos pais, uma constante despesa, quase que mensal com remédios e medicamentos. Com o intuito de economizar dinheiro, os pais buscam farmácias com os melhores preços e a melhor qualidade.|
| **Enzo Pereira** | **Jovem** |
|![Enzo Pereira](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-1/blob/main/docs/img/persona5.jpg)|Enzo Pereira é um estudante de ensino médio dos turnos da manhã e da tarde. De noite ele faz seu dever de casa, estuda e/ou vai jogar futebol com os amigos. Tem interesse em jogos e esportes, gosta de cultura pop, em especial filmes de heróis. Se informa pelo Twitter e possui muitos amigos com quem compartilha o final de semana. Enzo possui amigdalite crônica e necessita de cuidados para que a inflamação não o afete de modo muito severo. Porém, frequentemente Enzo possui dores de garganta que se desenvolvem em amigdalite e tem que tomar antibióticos. Enzo planeja sua cirurgia de remoção de amígdalas para o próximo ano.|
| **Jéssica Andrade** |	**Farmacêutica** |
|![Jéssica Andrade](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-1/blob/main/docs/img/persona6.jpg)|Jéssica é a farmacêutica responsável técnica da Farmácia Mais Saúde. Durante seus atendimentos, ela se depara com algumas dificuldades para compreender várias prescrições médicas que surgem mal escritas e/ou inelegíveis. Sua produtividade acaba sendo um pouco afetada por ter que dedicar tempo na tentativa de entendimento dessas prescrições sendo tanto de seus clientes quanto de clientes dos atendentes da farmácia.|


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
Fernando Oliveira  |  Ser lembrado do horário de tomar o meu remédio  |  Seguir corretamente a posologia
Fernando Oliveira  |  Encontrar facilmente farmácias próximas da minha localização  |  Comprar o meu remédio
Fernando Oliveira  |  Comparar os preços do meu remédio entre diferentes farmácias  |  Economizar na hora de comprar
Fernando Oliveira  |  Ser lembrado de levar o meu remédio quando sair de casa  |  Ter o remédio comigo na hora de tomá-lo
Maria Antônia Souza  |  Lembrar o horário de cada medicamento  |  Ter um tratamento eficiente
Maria Antônia Souza  |  Marcador de ingestão de medicamento do horário  |  Não haver superdosagem
Maria Antônia Souza  |  Controle de estoque  |  Não ficar sem medicamento
Maria Antônia Souza  |  Comparador de preço de medicamentos x distância de farmácia  |  Economizar tempo e dinheiro
João e Maria  |  Comparar preços de medicamentos  |  Economizar dinheiro
João e Maria  |  Comparar a qualidade de atendimento entre farmácias  |  Melhor atendimento e qualidade
Enzo Pereira  |  Fazer uma boa gestão de tempo de uso de antibióticos entre tratamento e intra tratamentos  |  Administrar melhor as vezes que toma remédio para amigdalite
Enzo Pereira  |  Ler bulas de medicamentos de forma dinâmica  |  Compreender melhor o uso de antibióticos e outros medicamentos
Gustavo Henrique  |  Poder receber dos clientes prescrições eletrônicas.  |  Facilitar e agilizar o atendimento do cliente.
Gustavo Henrique  |  Ter o pleno entendimento de qual medicamento está descrito na prescrição.  |  Evitar que ocorra algum mal-entendido ou troca da medicação.
Gustavo Henrique  |  Encaminhar para a farmacêutica a prescrição  |  Para validar a receita em casos de medicamentos em que a venda só pode ser feita mediante a retenção da prescrição ou validação do arquivo digital.
Jéssica Andrade  |  Poder receber dos clientes prescrições eletrônicas.  |  Identificar o(s) medicamento(s) e poder orientar de maneira fácil a forma de uso com horários e dosagens corretas.
Jéssica Andrade  |  Receber do atendente da farmácia a prescrição eletrônica  |  Para facilitar a verificação e retorno para o atendente
Jéssica Andrade  |  Validar as prescrições eletrônicas de medicamentos com controle especial  |  Para validar e armazenar as prescrições de medicamentos que exijam um controle especial da venda.

## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades de interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir.

### Requisitos Funcionais

| ID  |     Descrição do Requisito        |  Prioridade  |
|-----|-----------------------------------|  ----------  |
|RF-01|O sistema deve ter um cadastro de medicamentos, incluindo: nome, laboratório, dosagem, tipo (comprimido, gota, ampola, etc).|Alta
|RF-02|O sistema deve possuir um banco de dados de medicamentos para seleção do usuário no cadastro de tratamento|Baixa
|RF-03|O sistema deve permitir cadastro de tratamento, incluindo: nome do medicamento, dosagem, horários de ingestão e duração do tratamento.|Alta
|RF-04|O sistema deve permitir cadastro de usuário, contendo informações como: Nome, Idade, Peso, altura, telefone, cidade e bairro.|Média
|RF-05|O sistema deve permitir cadastro de estoque de medicamentos, com quantidade alterada quando usuário confirma a ingestão. |Média
|RF-06|O cadastro de estoque deve incluir data de validade e lote|Baixa
|RF-07|O sistema deve emitir alerta com notificação nos horários de ingestão cadastrados na posologia|Alta
|RF-08|O sistema deve emitir alerta de estoque baixo, considerando a quantidade definida pelo usuário (“quando estoque for menor que X comprimidos”)|Média
|RF-08|O sistema deve monitorar a localização do usuário e emitir alerta quando este se deslocar da sua residência (cadastrada no perfil) para que leve os remédios do tratamento cadastrado|Baixa
|RF-09|O sistema deve ter um sistema de localização de farmácias (pode ser pelo Google Maps), considerando a localização atual do usuário|Baixa
|RF-10|O sistema deve permitir a comparação de preços de um medicamento selecionado entre diversas farmácias|Baixa
|RF-11|O sistema deverá permitir ler de uma forma simples informações mais importantes da bula daquele medicamento|Baixa
|RF-12|O sistema deve permitir receber e encaminhar prescrição eletrônica|Média
|RF-13|O sistema deve permitir o registro da qualidade do atendimento das farmácias para futura comparação|Baixa


### Requisitos não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01|O sistema deve ter uma interface simples, clara e de fácil utilização;|Alta
|RNF-02|O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge);|Média
|RNF-03|Sistema acessível somente para pessoas cadastradas através de login e senha;|Média
|RNF-04|Sistema deverá seguir princípios de acessibilidade para todas as pessoas;|Média
|RNF-05|A aplicação deverá ser responsiva, permitindo a visualização em outros tipos de tela de forma adequada;|Alta
## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01|O Projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 30 de novembro de 2021.
|RE-02|O aplicativo deverá se restringir a programação de aplicação web, com integração de tecnologia de banco de dados e back-end.
|RE-03|A equipe não poderá subcontratar o desenvolvimento do trabalho.

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

![Diagrama de Casos de Uso](img/Diagrama_Casos_de_Uso.png)
