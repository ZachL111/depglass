# depglass

`depglass` explores developer tools in C#. The repository keeps the core rule set compact, then surrounds it with examples that show how the decisions move.

## Depglass Notes

The quickest review path is the verifier first, then the fixtures, then the operations note. That order makes it easy to see whether the code, data, and explanation still agree.

## Why This Exists

I use this kind of project to make a rule visible before adding more machinery around it. The important part here is not the size of the codebase. It is that the input signals, scoring rule, fixture data, and expected output can all be checked in one sitting.

## Example Scenarios

`degraded` is the first example I would inspect because it lands on the `review` path with a score of -22. The broader file also keeps `degraded` at -22 and `recovery` at 210, which gives the model a useful low-to-high spread.

## Implementation Notes

The project is organized around a compact model rather than a large framework. Inputs are scored, classified, and checked against golden fixtures. The constants live in code and are mirrored in metadata so documentation drift is easy to catch. The C# code keeps the core model in a small static API and runs checks through the executable path.

## Feature Notes

- Models code shape with deterministic scoring and explicit review decisions.
- Uses fixture data to keep diagnostics changes visible in code review.
- Includes extended examples for safe defaults, including `recovery` and `degraded`.
- Documents repeatable output tradeoffs in `docs/operations.md`.
- Runs locally with a single verification command and no external credentials.

## Try It

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

This runs the language-level build or test path against the compact fixture set.

## Tests

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/audit.ps1
```

The audit command checks repository structure and README constraints before it delegates to the verifier.

## Code Tour

- `src`: primary implementation
- `tests`: verification harness
- `fixtures`: compact golden scenarios
- `examples`: expanded scenario set
- `metadata`: project constants and verification metadata
- `docs`: operations and extension notes
- `scripts`: local verification and audit commands

## Roadmap

- Add a short report command that prints the score breakdown for a single scenario.
- Add malformed input fixtures so the failure path is as visible as the happy path.
- Split the scoring constants into a typed configuration object and validate it before use.
- Add one more developer tools fixture that focuses on a malformed or borderline input.

## Boundaries

The repository favors determinism over breadth. It does not pull live data, keep secrets, or depend on network access for verification.

## Local Setup

Install C# and run the commands from the repository root. The project does not need credentials or a hosted service.
