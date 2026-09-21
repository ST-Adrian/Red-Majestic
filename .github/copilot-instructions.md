# Copilot Instructions - Red Majestic

## Project context

Red Majestic is an academic C# console application built with .NET 10.

Before making changes, read:

- `docs/REQUIREMENTS.md`
- `docs/GOVERNANCE.md`
- `AGENTS.md`

These files define the project requirements, development rules, and AI constraints.

---

## Main rule

Academic requirements have priority over alternative implementation practices.

Do not replace required language structures or data types with alternatives, even if another option would normally be considered better practice.

---

## Required technical constraints

Respect the following requirements exactly:

- menu option: `int`
- card number: `string`
- card identifier: `string`
- last four digits: `string`
- general card validation: `switch`
- Visa transactions: `float[]`
- Mastercard transactions: `List<float>`
- Diners Club transactions: `Dictionary<int, float>`
- Visa display loop: `while`
- Mastercard display loop: `do-while`
- Diners Club display loop: `foreach`
- transaction collection loading: `for`

Do not replace these structures.

---

## Card identifiers

Use the following identifiers:

- Visa: `4407`
- Mastercard: `3890`
- Diners Club: `7401`

These values are the authoritative values for implementation.

---

## Scope discipline

When implementing an Issue:

- work only on the requested scope;
- do not add unrelated functionality;
- do not perform unrelated refactoring;
- do not change project technology;
- do not change the .NET version;
- do not add external dependencies unless explicitly requested;
- keep the implementation simple and appropriate for an academic console application.

---

## Implementation workflow

For each development task:

1. Read the GitHub Issue.
2. Identify the related requirements.
3. Review the relevant sections in `docs/REQUIREMENTS.md`.
4. Create or switch to the required feature branch.
5. Implement only the requested changes.
6. Build the project.
7. Verify the requested behavior when possible.
8. Review the diff.
9. Create a commit.
10. Push the working branch.
11. Report the result.

Do not merge into `main`.

---

## Git rules

Copilot may use Git commands to complete a task.

Allowed operations include:

- `git status`
- `git diff`
- `git branch`
- `git switch`
- `git checkout`
- `git add`
- `git commit`
- `git push`
- inspecting Git history

Copilot may create feature or fix branches when required.

Do not:

- commit directly to `main`;
- push directly to `main`;
- merge into `main`;
- use force push;
- rewrite Git history;
- delete remote branches without authorization;
- discard unrelated local changes.

Before changing branches, inspect the working tree and avoid overwriting uncommitted developer work.

---

## Branch naming

Use the branch specified by the Issue when one is provided.

Otherwise use:

- `feat/<short-description>` for features
- `fix/<short-description>` for fixes

Examples:

- `feat/main-menu`
- `feat/card-validation`
- `feat/visa-transactions`

---

## Commit behavior

Create focused commits related to the current task.

Commit messages should be short and descriptive.

Examples:

- `feat: add main menu`
- `feat: implement card validation`
- `feat: add visa transactions`
- `fix: correct invalid option handling`

Do not include unrelated changes in the same commit.

---

## Validation

Before considering a task complete:

- ensure the project builds;
- verify that the implementation matches the related requirements;
- verify that mandatory structures are present;
- check that no unrelated files were modified;
- inspect the final diff.

If something cannot be validated, report it instead of assuming success.

---

## Completion report

At the end of a task, report:

- Issue or task completed;
- branch used;
- main files changed;
- commit created;
- build result;
- validation performed;
- any ambiguity, limitation, or pending concern.

Do not merge the Pull Request or branch into `main`.