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
 <th>CTU-01 – Cadastro de novo usuário</th></tr>
 <tr><th>Perfil</th>
 <th>Cliente</th></tr>
 <tr><th>Objetivo do Teste</th>
 <th>Avaliar a tela de cadastro de novo usuário</th></tr>
 <tr><th>Ações necessárias</th>
 <th>Acessar a primeira tela do site pelo browser, conforme CTU-01;
 Clicar na opção “Cadastro”;
 Preencher os campos necessários do formulário;
 Navegar pelo fluxo de cadastro seguindo os passos orientados na tela e clicar em “Salvar.</th></tr>
</table>

<table>
 <tr><th>Caso de Teste</th>
 <th>CTU-02 – Login de usuário</th></tr>
 <tr><th>Perfil</th>
 <th>Cliente</th></tr>
 <tr><th>Objetivo do Teste</th>
 <th>Avaliar a usabilidade da tela de Login</th></tr>
 <tr><th>Ações necessárias</th>
 <th>Acessar o Navegador;
 Informar o endereço do Site;
 Visualizar a página de login;
 Preencher email no campo indicado
 Preencher senha no campo indicado;
 Clicar em ‘Login’.</th></tr>
</table>

<table>
 <tr><th>Caso de Teste</th>
<th>CTU-03 – Tela Funcionalidades</th></tr>
<tr><th>Perfil</th>
<th>Cliente</th></tr>
<tr><th>Objetivo do Teste</th>
<th>Avaliar a tela de funcionalidades do cliente</th></tr>
 <tr><th>Passos</th>
<th>Acessar o Navegador
Informar o endereço do Site
Visualizar a página principal
Clicar em Login
Preencher o email e a senha
Verificar a página principal do perfil</th></tr>
</table>

<table>
<tr><th>Caso de Teste</th>
<th>CTU-04 – Tela Funcionalidades</th></tr>
<tr><th>Perfil</th>
<th>Funcionário (Farmacêutico/Atendente)</th></tr>
<tr><th>Objetivo do Teste</th>
<th>Avaliar a tela de funcionalidades do funcionário</th></tr>
<tr><th>Passos</th>
<th>Acessar o Navegador
Informar o endereço do Site
Visualizar a página principal
Clicar em Login
Preencher o CPF e a senha
Verificar a página principal do perfil</th></tr>
 </table>

<table>
<tr><th>Caso de Teste</th>
<th>CTU-05 – Cadastro Tratamento</th></tr>
<tr><th>Perfil</th>
<th>Cliente</th></tr>
<tr><th>Objetivo do Teste</th>
<th>Avaliar o cadastro de tratamento</th></tr>
<tr><th>Passos</th>
<th>Acessar o Navegador;
Informar o endereço do Site;
Realizar o login;
Na tela Funcionalidades do Cliente, clicar no botão “Tratamentos”;
Na tela tratamentos, clicar no botão “Novo Tratamento”
Na opção Medicamento, quando o usuário começar a digitar, o espaço deve ser preenchido (a partir da primeira letra), caso o medicamento já esteja no banco de dados
Selecionar o ‘Nome do Medicamento’
Preencher os campos ‘Data Início’, ‘Duração’, ‘Frequência de Uso’ e ‘Anotações’;
Campo ‘Anotações’ não precisará ser obrigatório; e
Clicar no botão ‘Enviar’ para salvar o cadastro.</th></tr>
</table>

<table>
<tr><th>Caso de Teste</th>
<th>CTU-06 – Cadastro Medicamento</th></tr>
<tr><th>Perfil</th>
<th>Cliente</th></tr>
<tr><th>Objetivo do Teste</th>
<th>Avaliar o cadastro de Medicamentos</th></tr>
<tr><th>Passos</th>
<th>Acessar o Navegador;
Informar o endereço do Site;
Realizar o login;
Na tela Funcionalidades do Cliente, clicar no botão “Tratamentos”;
Na tela tratamentos, clicar no botão “Novo Tratamento”
Na tela de Cadastro de tratamento, clicar no botão “cadastro de medicamento”.
Preencher os campos de ‘Nome do Medicamento’, ‘Laboratório’, ‘Tipo’, ‘Dosagem’, ‘Princípio Ativo’;
Clicar no botão ‘Cadastrar’.</th></tr>
 </table>

<table>
<tr><th>Caso de Teste</th>
<th>CTU-07 - Atualização da “Caixinha de Remédios”</th></tr>
<tr><th>Perfil</th>
<th>Cliente</th></tr>
<tr><th>Objetivo do Teste</th>
<th>Avaliar a usabilidade da Caixinha de remédios</th></tr>
<tr><th>Passos</th>
<th>Acessar o navegador
Informar o endereço do Site;
Realizar o login;
Acessar a seção Caixinha de Remédios
Selecionar o Medicamento desejado e clicar em “Alterar quantidade”
Nos campos QUANTIDADE, DATA DE VALIDADE E LOTE DO MEDICAMENTO inserir dados válidos
Clicar em salvar</th></tr>
 </table>

<table>
<tr><th>Caso de Teste</th>
<th>CTU-08 – Importar e exportar prescrição</th></tr>
<tr><th>Perfil</th>
<th>Cliente</th></tr>
<tr><th>Objetivo do Teste</th>
<th>Avaliar o cadastro, envio e recebimento de prescrição</th></tr>
<tr><th> Passos</th>
<th>Acessar o navegador
Informar o endereço do Site;
Realizar o login;
Clicar no botão “Importar/Exportar arquivo”
Selecionar o arquivo da prescrição
Clicar em ENVIAR</th></tr>
 </table>
