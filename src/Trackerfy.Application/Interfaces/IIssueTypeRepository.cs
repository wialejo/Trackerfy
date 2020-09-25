using System.Threading;
using Trackerfy.Domain.Entities;

namespace Trackerfy.Application.Interfaces
{
    public interface IIssueTypeRepository
    {
        void Add(IssueType issueType);
        IssueType GetFirst();
        void Commit(CancellationToken cancellationToken = new CancellationToken());
    }
}