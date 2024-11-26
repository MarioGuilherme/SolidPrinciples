namespace SolidPrinciples.Srp;

public class PersonService(IPersonRepository personRepository, IQueueService serviceBusService, ErpSyncService erpSyncService) {
    private readonly IPersonRepository _personRepository = personRepository;
    private readonly IQueueService _serviceBusService = serviceBusService;
    private readonly ErpSyncService _erpSyncService = erpSyncService;

    // O m�todo agora corderna as operal��es delegando aos servi�os separados
    public void Add(PersonDto dto) {
        // Antes:

        // Realiza a persist�ncia abrindo a conex�o com o banco e implementando os detalhes Ccomo connection string, nome da tabela, colunas e etc
        // Realiza a sincronia com o ERP atr�ves de uma WEB API implementando os detalhes da requisi��o HTTP como URI, m�todo, corpo e etc
        // Realiza a publica��o da mensagem na fila do Azure Service Bus implementando os detalhes como nome da fila, routing keys, corpo da mensagem e etc

        // Os itens acima fere o pr�ncipio da responsabilidade �nica pois h� muitas responsabilidades na classe service (servi�o de aplica��o) [caso de uso]

        // Depois:
        Person person = new(dto.Name, dto.Document, dto.BirthDate);

        this._personRepository.Add(person);

        this._erpSyncService.SyncPerson(person);

        this._serviceBusService.Publish("nome_fila", person);
    }
}