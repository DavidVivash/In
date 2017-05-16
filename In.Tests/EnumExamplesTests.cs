using System;
using Xunit;

namespace In.Test
{
    public class EnumExamplesTests
    {
        [Theory]
        [InlineData(JobStatus.Completed)]
        [InlineData(JobStatus.Completing)]
        public void JobIsCompletingOrCompleted(JobStatus status)
        {
            // arrange
            var job = new Job { Status = status };

            // act
            var result = job.Status.In(JobStatus.Completing, JobStatus.Completed);

            // assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(JobStatus.Pending)]
        [InlineData(JobStatus.Running)]
        public void JobIsNotCompletingOrCompleted(JobStatus status)
        {
            // arrange
            var job = new Job { Status = status };

            // act
            var result = job.Status.In(JobStatus.Completing, JobStatus.Completed);

            // assert
            Assert.False(result);
        }
    }

    public class Job
    {
        public JobStatus Status { get; set; }
    }

    public enum JobStatus
    {
        Unknown,
        Pending,
        Running,
        Completing,
        Completed
    }
}
