namespace BlazorConcepts.Services
{
    public class TestService
    {

        public string Id { get; } = Guid.NewGuid().ToString();
    }
}
