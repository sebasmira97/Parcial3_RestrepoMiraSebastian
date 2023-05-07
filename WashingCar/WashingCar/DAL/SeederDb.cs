namespace WashingCar.DAL
{
    public class SeederDb
    {
        private readonly DatabaseContext _context;

        public SeederDb(DatabaseContext context)
        {
            _context = context;
        }

        public async Task SeederAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            //await PopulateTicketsAsync();
            await _context.SaveChangesAsync();
        }
    }
}
