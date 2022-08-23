namespace Admin_Blazor.Data
{
    public class SqlConnectionConfiguration
    {
        public string ConnectionString { get; set; }

        public SqlConnectionConfiguration(string stringConexao) => this.ConnectionString = stringConexao;

    }
}
