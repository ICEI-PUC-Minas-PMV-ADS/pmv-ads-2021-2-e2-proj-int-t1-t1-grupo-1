<h3>3.   Avaliação da Solução</h3>
<p>O processo de realização dos testes da solução desenvolvida está documentado na seção que se segue e traz os planos de testes de software e de usabilidade, na sequência, o registro dos testes realizados.</p>
 
<h3>Plano de Testes de Usabilidade</h3>
<h3>Avaliação do Percurso Cognitivo</h3>
Para cada um dos casos de teste listados a seguir, o avaliador deve fazer as seguintes perguntas e justificar as respostas:
O usuário tentaria alcançar o efeito desejado?
O usuário vai notar que a ação correta está disponível?
O usuário conseguirá associar a ação correta com o efeito que está tentando atingir?
O usuário perceberá que está progredindo em direção à conclusão da tarefa?

Em caso de respostas negativas, o avaliador deve propor uma solução, da seguinte maneira:
<table>
 <tr><th>Pergunta</th>  <th>Solução proposta</th></tr>
 <tr><th>1</th> <th>Eliminar a ação (se pertinente ou possível), fornecer uma instrução (propor a instrução) ou modificar a tarefa (propor a modificação)</th></tr>
<tr><th>2</th> <th> Tornar a ação mais evidente (propor a modificação)</th></tr>
<tr><th>3</th> <th> Renomear as ações e reescrever as instruções da interface (propor modificação)</th></tr>
<tr><th>4</th> <th> Destacar ou expressar mais claramente as respostas dos sistema (propor a modificação)</th></tr>
</table>

<table>
 <tr><th>Caso de Teste</th>
 <th>CTU-01 – Login de usuário</th></tr>
 <tr><th>Perfil</th>
 <th>Paciente</th></tr>
 <tr><th>Objetivo do Teste</th>
 <th>Avaliar a usabilidade da tela de Login</th></tr>
 <tr><th>Ações necessárias</th>
 <th>Acessar o Navegador;
 Informar o endereço do Site;
 Visualizar a página de login;
 Preencher CPF/ CRF no campo indicado
 Preencher senha no campo indicado;
 Selecionar tipo de usuário (“paciente”/“funcionário da farmácia”)
 Clicar em ‘Login’.</th></tr>
</table>

<table>
 <tr><th>Caso de Teste</th>
 <th>CTU-02 – Cadastro de novo usuário</th></tr>
 <tr><th>Perfil</th>
 <th>Paciente</th></tr>
 <tr><th>Objetivo do Teste</th>
 <th>Avaliar a tela de cadastro de novo usuário</th></tr>
 <tr><th>Ações necessárias</th>
 <th>Acessar a primeira tela do site pelo browser, conforme CTU-01;
 Clicar na opção “Cadastro”;
 Preencher os campos necessários do formulário;
 Navegar pelo fluxo de cadastro seguindo os passos orientados na tela e clicar em “Crie sua senha”.</th></tr>
</table>

<table>
 <tr><th>Caso de Teste</th>
<th>CTU-03 – Cadastro de Nova Senha</th></tr>
<tr><th>Perfil</th>
 <th>Paciente</th></tr>
 <tr><th>Objetivo do Teste</th>
 <th>Avaliar a tela de cadastro de nova senha</th></tr>
 <tr><th>Passos</th>
<th>Acessar o Navegador;
Informar o endereço do Site;
Visualizar a página de login;
Clicar na opção “Esqueci minha senha”
Na tela “Recuperação de acesso”, inserir o e-mail cadastrado;
Clicar no botão “próximo”
Na tela de “Código”, preencher no espaço indicado com o código recebido no e-mail de reset da senha;
Clicar em “Próximo”;
Inserir nova senha nos campos “senha” e “confirmação de senha”.
Clicar no botão ‘Concluir’ que levará para a próxima tela; </th></tr>
</table>

Caso de Teste
CTU-04 – Tela Perfil
Perfil
Paciente
Objetivo do Teste
Avaliar a tela de perfil do paciente
Passos
Acessar o Navegador
Informar o endereço do Site
Visualizar a página principal
Clicar em Login
Preencher o CPF e a senha
Verificar a página principal do perfil



Caso de Teste
CTU-05 – Tela Perfil
Perfil
Atendente
Objetivo do Teste
Avaliar a tela de perfil do atendente
Passos
Acessar o Navegador
Informar o endereço do Site
Visualizar a página principal
Clicar em Login
Preencher o CPF e a senha
Verificar a página principal do perfil



Caso de Teste
CTU-06 – Tela Perfil
Perfil
Farmacêutico
Objetivo do Teste
Avaliar a tela de perfil do farmacêutico
Passos
Acessar o Navegador
Informar o endereço do Site
Visualizar a página principal
Clicar em Login
Preencher o CRF e a senha
Verificar a página principal do perfil



Caso de Teste
CTU-07 – Cadastro Tratamento
Perfil
Paciente
Objetivo do Teste
Avaliar o cadastro de tratamento
Passos
Acessar o Navegador;
Informar o endereço do Site;
Realizar o login;
Na tela Perfil, clicar no botão “Tratamentos”;
Na tela tratamentos, clicar no botão “Novo Tratamento”
Na opção Medicamento, quando o usuário começar a digitar, o espaço deve ser preenchido (a partir da primeira letra), caso o medicamento já esteja no banco de dados
Selecionar o ‘Nome do Medicamento’
Preencher os campos ‘Data Início’, ‘Duração’, ‘Frequência de Uso’ e ‘Anotações’;
Inserir a bula (Formato PDF, JPG, PNG ou BMP)
 Campo ‘Anotações’ não precisará ser obrigatório; e
 Clicar no botão ‘Enviar’ para salvar o cadastro.



Caso de Teste
CTU-08 – Cadastro Medicamento
Perfil
Paciente
Objetivo do Teste
Avaliar o cadastro de Medicamentos
Passos
Acessar o Navegador;
Informar o endereço do Site;
Realizar o login;
Na tela Perfil, clicar no botão “Tratamentos”;
Na tela tratamentos, clicar no botão “Novo Tratamento”
Na tela de Cadastro de tratamento, clicar no botão “cadastro de medicamento”.
Preencher os campos de ‘Nome do Medicamento’, ‘Laboratório’, ‘Tipo’, ‘Dosagem’, ‘Princípio Ativo’;
Inserir a bula (Formato PDF, JPG, PNG ou BMP)
Clicar no botão ‘Cadastrar’.


Caso de Teste
CTU-09 - Atualização da “Caixinha de Remédios”
Perfil
Paciente
Objetivo do Teste
Avaliar a usabilidade da Caixinha de remédios
Passos
Acessar o navegador
Informar o endereço do Site;
Realizar o login;
Acessar a seção Caixinha de Remédios
Selecionar o Medicamento desejado e clicar em “Alterar quantidade”
Nos campos QUANTIDADE, DATA DE VALIDADE E LOTE DO MEDICAMENTO inserir dados válidos
Clicar em salvar



Caso de Teste
CTU-10 – Importar e exportar prescrição
Perfil
Paciente
Objetivo do Teste
Avaliar o cadastro, envio e recebimento de prescrição
 Passos
Acessar o navegador
Informar o endereço do Site;
Realizar o login;
Clicar no botão “Importar/Exportar arquivo”
Selecionar o arquivo da prescrição
Clicar em ENVIAR


Caso de Teste
CTU-11–Pesquisa de preços
Perfil
Paciente
Objetivo do Teste
Avaliar as opções da pesquisa de preços
Passos
1)   Acessar o Navegador;
2)   Informar o endereço do Site;
3)   Acessar a página ‘Pesquisa de preço’;
4)   Visualizar o campo de preenchimento relativo ao nome do medicamento.
5)   Campo ‘Busca de medicamento’ deve estar acessível para preenchimento;
6)   Clicar na lupa para efetuar a busca;
7)   Ao buscar o medicamento, o aplicativo deve possuir um sistema de localização que permita mostrar as farmácias mais próximas da residência do usuário
8) Em seguida deve apresentar várias farmácias onde o medicamento encontra-se disponível e cada uma com o preço praticado;
9) O ícone da farmácia deve ser um link de redirecionamento para a mesma, possibilitando ao paciente comprar o medicamento on-line, e, caso deseje, fornecer o endereço físico para compra presencial.
10) O sistema deve apresentar uma opção de avaliação do atendimento após a compra realizada com notas de 0 (para muito ruim) a 5 (para muito bom).



Caso de Teste
CTU-10 - Notificações
Perfil
Paciente
Objetivo do Teste
Avaliar o sistema de alarmes da aplicação 
Passos
1) Acessar o navegador
2) Informar o endereço do Site;
3) Realizar o login;
4) Acessar a seção Notificações
5) Selecionar a opção “Notificação de ingestão”
6) Deve apresentar uma tela para marcar horário de ingestão de cada medicamento (tendo a opção de adicionar quantos medicamentos forem necessários) e clicar em “Repetir todos os dias”
7) Clicar em salvar
8) Depois que soar o alarme, deve apresentar uma opção de confirmação de ingestão
9) Selecionar a opção “Notificação de Caixinha”
10) Deve apresentar uma tela para marcar a quantidade mínima de cada medicamento (tendo a opção de adicionar quantos medicamentos forem necessários) para soar o alarme
11) Clicar em salvar
12) Selecionar a opção “Notificação de afastamento de casa”
13) Deve apresentar uma tela para ativar localização e distância que o alarme deve disparar
14) Clicar em salvar



