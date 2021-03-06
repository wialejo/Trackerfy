using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Trackerfy.Application.Issues.Commands.CreateIssue;
using Trackerfy.Application.Issues.Commands.UpdateIssueState;
using Trackerfy.Application.Issues.Queries.GetAllIssues;
using Trackerfy.Application.Issues.Queries.GetIssueById;
using Trackerfy.Application.Issues.Queries.GetIssuesByState;
using Trackerfy.Application.Issues.Queries.GetIssueStatesStatistics;

namespace Trackerfy.API.Controllers.Issues
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public IssuesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateIssueRequest request, CancellationToken cancellationToken)
        {
            var command = new CreateIssueCommand(request.Summary, request.IssueTypeId);
            return await _mediator.Send(command, cancellationToken);
        }

        [HttpGet]
        public async Task<ActionResult<List<IssueDTO>>> Get(CancellationToken cancellationToken)
        {
            var query = new GetAllIssuesQuery();
            return await _mediator.Send(query, cancellationToken);
        }

        [HttpGet]
        [Route("{issueId}")]
        public async Task<ActionResult<IssueDTO>> GetById(int issueId, CancellationToken cancellationToken)
        {
            var query = new GetIssueByIdQuery(issueId);
            return await _mediator.Send(query, cancellationToken);
        }

        [HttpGet]
        [Route("state/{stateId}")]
        public async Task<ActionResult<List<IssueDTO>>> Get(int stateId, CancellationToken cancellationToken)
        {
            var query = new GetIssuesByStateQuery(stateId);
            return await _mediator.Send(query, cancellationToken);
        }

        [HttpGet]
        [Route("statistics")]
        public async Task<ActionResult<List<IssueStateStatisticDTO>>> GetStatistics(CancellationToken cancellationToken)
        {
            var query = new GetIssuesStatisticsQuery();
            return await _mediator.Send(query, cancellationToken);
        }

        [HttpPut("{issueId}/state")]
        public async Task<Unit> Update(int issueId, UpdateIssueStateRequest request, CancellationToken cancellationToken)
        {
            var command = new UpdateIssueStateCommand(issueId, request.IssueStateId);
            return await _mediator.Send(command, cancellationToken);
        }
    }

}