# Plano de Testes de Software
 **Requisitos para realização do teste:**
* Site publicado na Internet;
* Navegador da Internet - Chrome, Firefox ou Edge.
Os testes funcionais a serem realizados no aplicativo são descritos a seguir.
  
|**Caso de Teste**|**CT-01 – Validar tela de login**|
|-----------------|---------------------------------|
|**Requisitos Associados**|RF-14 - O sistema deve apresentar na página principal uma área de login e a opção para se cadastrar novo usuário.|
|**Objetivo do Teste**|Verificar se os campos do formulário estão sendo exibidos corretamente.|
|**Passos**|Acessar o Navegador; Informar o endereço do Site; Visualizar a página de login; Preencher e-mail no campo indicado; Preencher senha no campo indicado; Clicar em ‘Login’.|
|**Critérios de Êxito**|O campo email deve verificar se o usuário digitou uma informação válida; O texto preenchido no campo de senha deve ser oculto; Ao clicar em ‘login’ será direcionado para home.|


|**Caso de Teste**|**CT-02 – Cadastro de novo usuário**|
|-----------------|---------------------------------|
|**Requisitos Associados**|RF-04 - O sistema deve apresentar 3 formulários de cadastro para novos usuários (um para paciente, outro para farmacêutico e outro para atendente da farmácia) contendo: Nome, CPF/CRF, data de nascimento (apenas do paciente), telefone, e-mail, senha.|
|**Objetivo do Teste**|Verificar se os campos do formulário de cadastrar novo usuário está validando os campos corretamente conforme seu respectivo dado.|
|**Passos**|Acessar a primeira tela do site pelo browser, conforme CT-01; Clicar na opção “Cadastro Paciente”, "Cadastro Atendente" ou "Cadastro Farmacêutico"; Preencher os campos necessários do formulário; Navegar pelo fluxo de cadastro seguindo os passos orientados na tela e clicar em “Finalizar cadastro”.|
|**Critérios de Êxito**|Na primeira tela do fluxo de cadastro, apenas uma opção pode ser selecionada (“Cadastro Paciente”/”Cadastro Atendente”/"Cadastro Farmacêutico") para direcionar para a tela correta de cada usuário; Na segunda tela do fluxo o campo CPF/CRF deve validar se o usuário digitou 11 ou 6 dígitos e se foi só números; Ainda na segunda tela, também deve ser verificado se o e-mail digitado é válido; nos campos de senha devem validar se a primeira senha digitada corresponde à segunda; Ainda nesta tela, os campos de senha devem manter a informação digitada oculta; Ao clicar em concluir cadastro, deve aparecer a mensagem de Cadastro concluído com sucesso!; Ao clicar em Fazer Login, o usuário deve ser direcionado para a página de Login.|


|**Caso de Teste**|**CT-03 – Cadastro de Nova Senha**|
|-----------------|---------------------------------|
|**Requisitos Associados**|RF-15 - O sistema deve conter um formulário que permita ao usuário cadastrar uma nova senha em caso de esquecimento;|
|**Objetivo do Teste**|Verificar se os campos do formulário estão sendo exibidos corretamente.|
|**Passos**|Acessar o Navegador; Informar o endereço do Site; Visualizar a página de login; Clicar na opção “Esqueci minha senha”; Na tela “Recuperação de acesso”, inserir o e-mail cadastrado; Clicar no botão “próximo”; Na tela de “Código”, preencher no espaço indicado com o código recebido no e-mail de reset da senha; Clicar em “Próximo”; Inserir nova senha nos campos “senha” e “confirmação de senha”; Clicar no botão ‘Concluir’ que levará para a próxima tela.|
|**Critérios de Êxito**|Campo e-mail deve ser preenchido e deve verificar se o usuário digitou uma informação válida; O e-mail com o código deve ser recebido no endereço cadastrado e indicado; O campo de código deve verificar se o código informado é válido; Os campos de senha devem validar se a primeira senha digitada corresponde à segunda; Ao concluir, deve aparecer a mensagem de Senha cadastrada com sucesso.|



|**Caso de Teste**|**CT-04 – Tela Perfil**|
|-----------------|---------------------------------|
|**Requisitos Associados**|RF-12 – O sistema deve permitir receber e encaminhar prescrição eletrônica (Importar e exportar); RF-16 - O site deve conter área logada (Perfil) que conforme o logon de cada perfil (paciente / Funcionário da farmácia) que deverá mostrar o conteúdo apropriado; RF-17 - A tela Perfil deve contemplar informações importantes para ambos os tipos de usuários como: Tratamentos, Medicamentos, Menor preço de medicamentos, Cadastrar medicamento, Visualizar receita, Cadastrar tratamento (Considerando o tipo de cada perfil).|
|**Perfil**|Paciente|
|**Objetivo do Teste**|Verificar se após o login é exibido a tela principal do perfil|
|**Passos**|Acessar o Navegador; Informar o endereço do Site; Visualizar a página principal; Clicar em Login; Preencher o CPF e a senha; Verificar a página principal do perfil.|
|**Critérios de Êxito**|Ser direcionado automaticamente para a tela principal após o formulário de login; Na tela principal deve aparecer as seguintes informações/funcionalidades: Botão “Tratamentos”; Botão “Medicamentos”; Botão “Visualizar Receitas”; Botão “Importar/Exportar arquivo”; Próximos medicamentos a serem ingeridos (Nome do medicamento, hora e quantidade); Caixinha de Remédios, indicando os medicamentos cadastrados em algum tratamento e a quantidade restante.|



|**Caso de Teste**|**CT-05 – Tela Perfil**|
|-----------------|---------------------------------|
|**Requisitos Associados**|RF-12 – O sistema deve permitir receber e encaminhar prescrição eletrônica (Importar e exportar); RF-16 - O site deve conter área logada (Perfil) que conforme o logon de cada perfil (paciente / Funcionário da farmácia) que deverá mostrar o conteúdo apropriado; RF-17 - A tela Perfil deve contemplar informações importantes para ambos os tipos de usuários como: Tratamentos, Medicamentos, Menor preço de medicamentos, Cadastrar medicamento, Visualizar receita, Cadastrar tratamento (Considerando o tipo de cada perfil).|
|**Perfil**|Funcionário da Farmácia (Atendente/Farmacêutico)|
|**Objetivo do Teste**|Verificar se após o login é exibido a tela principal do perfil.|
|**Passos**|Acessar o Navegador; Informar o endereço do Site; Visualizar a página principal; Clicar em Login; Preencher o CPF e a senha; Verificar a página principal do perfil.|
|**Critérios de Êxito**|Ser direcionado automaticamente para a tela principal após o formulário de login; Na tela principal deve aparecer as seguintes informações/funcionalidades: Botão; Botão “Medicamentos”; Botão “Importar/Exportar arquivo”.|



|**Caso de Teste**|**CT-06 – Cadastro Tratamento**|
|-----------------|---------------------------------|
|**Requisitos Associados**|RF-02 – O sistema deve possuir um banco de dados de medicamentos para seleção do usuário no cadastro de tratamento; RF-03 - O sistema deve permitir cadastro de tratamento, incluindo: nome do medicamento, dosagem, horários de ingestão e duração do tratamento; RF-11 – O sistema deve permitir a inserção e a leitura de bulas de medicamentos.|
|**Perfil**|Paciente|
|**Objetivo do Teste**|Verificar se as opções de cadastro estão sendo exibidas e executadas corretamente.|
|**Passos**|Acessar o Navegador; Informar o endereço do Site; Realizar o login; Na tela Perfil, clicar no botão “Tratamentos”; Na tela tratamentos, clicar no botão “Novo Tratamento”; Na opção Medicamento, quando o usuário começar a digitar, o espaço deve ser preenchido (a partir da primeira letra), caso o medicamento já esteja no banco de dados; Selecionar o ‘Nome do Medicamento’; Preencher os campos ‘Data Início’, ‘Duração’, ‘Frequência de Uso’ e ‘Anotações’; Inserir a bula (Formato PDF, JPG, PNG ou BMP); Campo ‘Anotações’ não precisará ser obrigatório; e Clicar no botão ‘Enviar’ para salvar o cadastro.|
|**Critérios de Êxito**|Os campos para preenchimento deverão permitir a entrada de dados; O autopreenchimento do nome do medicamento deve funcionar, caso o medicamento esteja cadastrado no banco de dados; O usuário deverá conseguir salvar as informações inseridas mesmo com o campo ‘Anotações’ em branco; Após clicar em “Enviar”, deve-se retornar automaticamente para a tela “Tratamentos”; O tratamento cadastrado deve estar relacionado nos tratamentos desta tela; A bula deve estar disponível para leitura.|



|**Caso de Teste**|**CT-07 – Cadastro Medicamento**|
|-----------------|---------------------------------|
|**Requisitos Associados**|RF-01 - O sistema deve ter um cadastro de medicamentos, incluindo: nome, laboratório, dosagem, tipo (comprimido, gota, ampola, etc); RF-11 – O sistema deve permitir a inserção e a leitura de bulas de medicamentos;
|**Perfil**|Paciente|
|**Objetivo do Teste**|Verificar se as opções de cadastro estão sendo exibidas e executadas corretamente.|
|**Passos**|Acessar o Navegador; Informar o endereço do Site; Realizar o login; Na tela Perfil, clicar no botão “Tratamentos”; Na tela tratamentos, clicar no botão “Novo Tratamento”; Na tela de Cadastro de tratamento, clicar no botão “cadastro de medicamento”; Preencher os campos de ‘Nome do Medicamento’, ‘Laboratório’, ‘Tipo’, ‘Dosagem’, ‘Princípio Ativo’; Inserir a bula (Formato PDF, JPG, PNG ou BMP); Clicar no botão ‘Cadastrar’.|
 |**Critérios de Êxito**|Os campos para preenchimento deverão permitir a entrada de dados; Após clicar em Cadastrar, deve-se retornar automaticamente para a tela Cadastrar Tratamento, com o medicamento cadastrado já selecionado; A bula deve estar disponível para leitura.|


|**Caso de Teste**|**CT-08 – Atualização da “Caixinha de Remédios”**|
|-----------------|---------------------------------|
|**Requisitos Associados**|RF-05 – O sistema deve permitir cadastro de Caixinha de medicamentos, com quantidade alterada quando usuário confirma a ingestão; RF-06 – O cadastro de Caixinha deve incluir data de validade e lote.|
|**Perfil**|Paciente|
|**Objetivo do Teste**|Verificar o cadastro de quantidade, data de validade e lote na tela de CAIXINHA|
|**Passos**|Acessar o navegador; Informar o endereço do Site; Realizar o login; Acessar a seção Caixinha de Remédios; Selecionar o Medicamento desejado e clicar em “Alterar quantidade”; Nos campos QUANTIDADE, DATA DE VALIDADE E LOTE DO MEDICAMENTO inserir dados válidos; Clicar em salvar.|
|**Critérios de Êxito**|Após clicar em salvar, deve retornar automaticamente para a tela Caixinha de Remédios;Ao retornar para a Caixinha de Remédios, Cadastrar a quantidade, data de validade e lote e consultá-lo posteriormente pelo menu de buscas de produtos.|



|**Caso de Teste**|**CT-09 – Importar e exportar prescrição**|
|-----------------|---------------------------------|
|**Requisitos Associados**|RF-12 – O sistema deve permitir receber e encaminhar prescrição eletrônica (Importar e exportar)|
|**Perfil**|Paciente|
|**Objetivo do Teste**|Verificar o cadastro, envio e recebimento de prescrição.|
|**Passos**|Acessar o navegador; Informar o endereço do Site; Realizar o login; Clicar no botão “Importar/Exportar arquivo”; Selecionar o arquivo da prescrição; Clicar em ENVIAR.|
|**Critérios de Êxito**|Cadastrar data de validade e lote e consultá-lo posteriormente pelo menu de buscas de produtos.|


|**Caso de Teste**|**CT-10 – Pesquisa de preços**|
|-----------------|---------------------------------|
|**Requisitos Associados**|RF-09 – O sistema deve ter um sistema de localização de farmácias (pode ser pelo Google Maps), considerando a localização atual do usuário; RF-10 - O sistema deve permitir a comparação de preços de um medicamento selecionado entre diversas farmácias; RF-13 – O sistema deve permitir o registro da qualidade do atendimento das farmácias para futura comparação.|
|**Perfil**|Paciente|
|**Objetivo do Teste**|Verificar se as opções da pesquisa foram preenchidas corretamente.|
|**Passos**| Acessar o Navegador; Informar o endereço do Site; Acessar a página ‘Pesquisa de preço’; Visualizar o campo de preenchimento relativo ao nome do medicamento; Campo ‘Busca de medicamento’ deve estar acessível para preenchimento; Clicar na lupa para efetuar a busca; Ao buscar o medicamento, o aplicativo deve possuir um sistema de localização que permita mostrar as farmácias mais próximas da residência do usuário; Em seguida deve apresentar várias farmácias onde o medicamento encontra-se disponível e cada uma com o preço praticado; O ícone da farmácia deve ser um link de redirecionamento para a mesma, possibilitando ao paciente comprar o medicamento on-line, e, caso deseje, fornecer o endereço físico para compra presencial; O sistema deve apresentar uma opção de avaliação do atendimento após a compra realizada com notas de 0 (para muito ruim) a 5 (para muito bom).|
|**Critérios de Êxito**|Os campos para preenchimento deverão permitir a entrada de dados; Os links das farmácias devem estar disponíveis para redirecionamento; O aplicativo deve apresentar as distâncias das farmácias da pesquisa, mostrando primeiro as mais próximas de sua residência; A opção de avaliação de qualidade deve apresentar o resultado da avaliação feita pelo usuário.|



|**Caso de Teste**|**CT-11 - Notificações**|
|-----------------|---------------------------------|
|**Requisitos Associados**|RF-05 – O sistema deve permitir cadastro de Caixinha de medicamentos, com quantidade alterada quando usuário confirma a ingestão; RF-07 – O sistema deve emitir alerta com notificação nos horários de ingestão cadastrados na posologia; RF-08 – O sistema deve emitir alerta de quantidade baixa de medicamento, considerando a quantidade definida pelo usuário (“quando quantidade for menor que X comprimidos”).|
|**Perfil**|Paciente|
|**Objetivo do Teste**|Verificar se o sistema de alarmes do aplicativo está funcionando corretamente|
|**Passos**|Acessar o navegador; Informar o endereço do Site; Realizar o login; Acessar a seção Notificações; Selecionar a opção “Notificação de ingestão”; Deve apresentar uma tela para marcar horário de ingestão de cada medicamento (tendo a opção de adicionar quantos medicamentos forem necessários) e clicar em “Repetir todos os dias”; Clicar em salvar; Depois que soar o alarme, deve apresentar uma opção de confirmação de ingestão; Selecionar a opção “Notificação de Caixinha”; Deve apresentar uma tela para marcar a quantidade mínima de cada medicamento (tendo a opção de adicionar quantos medicamentos forem necessários) para soar o alarme; Clicar em salvar; Selecionar a opção “Notificação de afastamento de casa”; Deve apresentar uma tela para ativar localização e distância que o alarme deve disparar; Clicar em salvar.|
|**Critérios de Êxito**|O alarme deve soar nos horários definidos para cada medicamento e apresentar uma notificação do que deverá ser consumido; Depois de soado o alarme, apresentar a tela para confirmar ingestão; O alarme deve soar quando o nível do medicamento alcançar o nível registrado; O alarme deve soar quando ultrapassar a distância da residência definida no registro de “Notificação de afastamento de casa”.|


