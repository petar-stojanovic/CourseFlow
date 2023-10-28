using CourseFlow.Data;
using CourseFlow.Repository.LessonRepository;

namespace CourseFlow.Services
{
    public class ScheduledService : IHostedService, IDisposable
    {
        private Timer _timer;
        private bool _executed = false;

        private readonly IServiceScopeFactory _scopeFactory;

        public ScheduledService(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            // Set the time interval for execution (e.g., 10 seconds for testing)
            var interval = TimeSpan.FromMinutes(10);

            _timer = new Timer(ExecuteCode, null, TimeSpan.Zero, interval);

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }

        private void ExecuteCode(object state)
        {
            if (!_executed)
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<DataContext>();
                    var lessons = context.Lessons.Where(l =>
                        l.Course.Title == "Admin" && l.Course.Description == "This is a course for unassigned lessons");
                    foreach (var lesson in lessons)
                    {
                        context.Lessons.Remove(lesson);
                    }

                    context.SaveChanges();
                }
            }
        }
    }
}
