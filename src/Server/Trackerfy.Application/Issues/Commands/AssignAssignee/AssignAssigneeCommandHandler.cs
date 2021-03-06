using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Trackerfy.Application.Common.Interfaces;

namespace Trackerfy.Application.Issues.Commands.AssignAssignee
{
    public class AssignAssigneeCommandHandler: IRequestHandler<AssignAssigneeCommand, int>
    {
        private readonly IIssueRepository _issueRepository;

        public AssignAssigneeCommandHandler(IIssueRepository issueRepository)
        {
            _issueRepository = issueRepository;
        }

        public async Task<int> Handle(AssignAssigneeCommand request, CancellationToken cancellationToken)
        {
            var issue = await _issueRepository.findByIdAsync(request.IssueId);

            issue.AssignAssignee(request.AssigneeUserId);

            await _issueRepository.Commit(cancellationToken);

            return issue.Id;
        }
    }
}