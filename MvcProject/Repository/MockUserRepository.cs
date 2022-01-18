using LINQtoCSV;

namespace MvcProject.Repository
{
    public class MockUserRepository : IMockUserRepository
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public MockUserRepository(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IEnumerable<Models.MockUser> GetAll()
        {
            var mockUsersFileDescription = new CsvFileDescription
            {
                SeparatorChar = ',',
                FirstLineHasColumnNames = true
            };

            return new CsvContext().Read<Models.MockUser>($"{_webHostEnvironment.ContentRootPath}/App_Data/mock_data.csv", mockUsersFileDescription);
        }
    }
}
