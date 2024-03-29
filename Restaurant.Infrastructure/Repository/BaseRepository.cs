using Restaurant.Domain.SeedWork;

namespace Restaurant.Infrastructure.Repository
{
    public class BaseRepository
    {
        #region Properties

        public readonly string _connectionString;
        public readonly ILogger _logger;
        public string _commandText { get; set; } = string.Empty;

        #endregion

        #region Constructor

        public BaseRepository(ILogger logger)
        {
            _connectionString = "Data Source=rodrigofurlaneti31_donne.sqlserver.dbaas.com.br;Initial Catalog=rodrigofurlaneti31_donne;User Id=rodrigofurlaneti31_donne; Password=Digo310884@";
            _logger = logger;
        }

        #endregion
    }
}
