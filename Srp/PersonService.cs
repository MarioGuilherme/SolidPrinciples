namespace SolidPrinciples.Srp;

public class PersonService(IPersonRepository personRepository, IQueueService serviceBusService, ErpSyncService erpSyncService) {
    private readonly IPersonRepository _personRepository = personRepository;
    private readonly IQueueService _serviceBusService = serviceBusService;
    private readonly ErpSyncService _erpSyncService = erpSyncService;

    // O método agora corderna as operalções delegando aos serviços separados
    public void Add(PersonDto dto) {
        // Antes:

        // Realiza a persistência abrindo a conexão com o banco e implementando os detalhes Ccomo connection string, nome da tabela, colunas e etc
        // Realiza a sincronia com o ERP atráves de uma WEB API implementando os detalhes da requisição HTTP como URI, método, corpo e etc
        // Realiza a publicação da mensagem na fila do Azure Service Bus implementando os detalhes como nome da fila, routing keys, corpo da mensagem e etc

        // Os itens acima fere o príncipio da responsabilidade única pois há muitas responsabilidades na classe service (serviço de aplicação) [caso de uso]

        // Depois:
        Person person = new(dto.Name, dto.Document, dto.BirthDate);

        this._personRepository.Add(person);

        this._erpSyncService.SyncPerson(person);

        this._serviceBusService.Publish("nome_fila", person);
    }
}