namespace SolidPrinciples.Isp;

public class GymUnitRepository(GymDbContext context) : IReadOnlyRepository<GymUnit> {
    private readonly GymDbContext _context = context;

    public IEnumerable<GymUnit> GetAll(Guid id) {
        return _context.Gyms;
    }

    public GymUnit GetById(Guid id) {
        return _context.Gyms.SingleOrDefault(g => g.Id == id);
    }
}