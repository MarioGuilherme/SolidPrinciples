namespace SolidPrinciples.Dip;

public class PersonService(IPersonRepository repository, IErpSyncService erpService, IMessageBusService messageBusService) : IPersonService {
    private readonly IPersonRepository _repository = repository;
    private readonly IErpSyncService _erpService = erpService;
    private readonly IMessageBusService _messageBusService = messageBusService;

    public void Add(PersonDto dto) {
        Person person = new(dto.Name, dto.Document, dto.BirthDate);

        this._repository.Add(person);

        this._erpService.SyncPerson(person);

        this._messageBusService.Publish("nome_fila", person);
    }
}