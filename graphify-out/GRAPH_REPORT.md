# Graph Report - EventsHub  (2026-11-17)

## Corpus Check
- 110 files · ~104,813 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 16 file(s) not represented in the graph (top: (none) 12, .scss 2, .nswag 1)

## Summary
- 898 nodes · 1437 edges · 61 communities (44 shown, 17 thin omitted)
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 68 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `870330cc`
- Run `git rev-parse HEAD` and compare to check if the graph is stale.
- Run `graphify update .` after code changes (no API cost).

## Community Hubs (Navigation)
- EventsRpcClient
- EventsController.cs
- Event
- package.json
- Clean Architecture fundamentals
- Graphify knowledge graph workflow
- EventsHub.Application.UnitTests.csproj
- EventsControllerTests
- compilerOptions
- MapperTests
- devDependencies
- Event
- compilerOptions
- EventsHub architecture snapshot September 2026
- Local baseUrl: https://localhost:5001/api/v1
- Part 4: npm only, `package.json` in a subfolder (Husky v9)
- https
- EventsHub.OpenApi
- ActivityCard.tsx
- WeatherForecast
- Git in practice
- InitialCreate
- web_src_index
- React + TypeScript + Vite template
- Repository guidelines
- Architecture documentation workflow
- tsconfig.json
- Events Hub HTML entry point
- Part 1: .NET + npm in the same repo (e.g. EventsHub)
- Part 3: npm only, `package.json` in the repo root (Husky v9)
- dependencies
- routes.tsx
- index.d.ts
- ActivitysHub ICI 2026
- openspec-explore/SKILL.md
- scripts
- TypeMap
- HandlerTestBase
- Mapper
- Domain
- EventsHub.Application.Core.Mapping
- @mui/material
- Part 2: .NET only (Husky.Net)
- Persistence
- EventsHub.Application.Events.Commands
- useActivities.tsx
- AppDbContextModelSnapshot
- husky-setup.md
- .SeedDataAsync
- task-runner.json
- MappingServiceCollectionExtensions
- lint-staged
- commit-msg
- pre-commit
- automapper
- system_runtime_compilerservices

## God Nodes (most connected - your core abstractions)
1. `Event` - 30 edges
2. `TypeMap` - 24 edges
3. `EventsRpcClient` - 20 edges
4. `WeatherForecastRpcClient` - 19 edges
5. `MapperTests` - 19 edges
6. `EventsControllerTests` - 18 edges
7. `compilerOptions` - 18 edges
8. `EventsHub.Application.Core.Mapping` - 15 edges
9. `AppDbContext` - 15 edges
10. `@mui/material` - 15 edges

## Surprising Connections (you probably didn't know these)
- `Replace on reextract` --semantically_similar_to--> `Read model projection`  [INFERRED] [semantically similar]
  .codex/skills/graphify/references/update.md → docs/fundamentals/CqrsFundamentals.md
- `Graphify` --conceptually_related_to--> `Graphify knowledge graph workflow`  [INFERRED]
  docs/guides/install-graphify-openspec.md → .codex/skills/graphify/SKILL.md
- `EditEventTests` --references--> `IMapper`  [EXTRACTED]
  tests/EventsHub.Application.UnitTests/Events/EditEventTests.cs → src/EventsHub.Application/Core/Mapping/IMapper.cs
- `EventSummaryProfile` --inherits--> `Profile`  [EXTRACTED]
  tests/EventsHub.Application.UnitTests/Mapping/DocumentedProfileExample.cs → src/EventsHub.Application/Core/Mapping/Profile.cs
- `PersonProfile` --inherits--> `Profile`  [EXTRACTED]
  tests/EventsHub.Application.UnitTests/Mapping/MapperFixtures.cs → src/EventsHub.Application/Core/Mapping/Profile.cs

## Import Cycles
- None detected.

## Hyperedges (group relationships)
- **Documented event query flow** — docs_arquitectura_react_frontend, docs_arquitectura_axios_json_requests, docs_arquitectura_eventscontroller, docs_arquitectura_appdbcontext, docs_arquitectura_sqlite [EXTRACTED 1.00]

## Communities (61 total, 17 thin omitted)

### Community 0 - "EventsRpcClient"
Cohesion: 0.07
Nodes (37): EventsHub.OpenApi.Client, JsonSerializerSettings, CultureInfo, Exception, global_system, HttpClient, HttpContent, HttpRequestMessage (+29 more)

### Community 1 - "EventsController.cs"
Cohesion: 0.14
Nodes (12): ControllerBase, EventsHub.API.Controllers, IMediator, microsoft_aspnetcore_mvc, newtonsoft_json_serialization, EventsHubBaseController, Mediator, HttpGet (+4 more)

### Community 2 - "Event"
Cohesion: 0.06
Nodes (43): Command, DbContext, DbContextOptions, DbSet, IRequestHandler, OneTimeSetUp, OneTimeTearDown, Query (+35 more)

### Community 3 - "package.json"
Cohesion: 0.08
Nodes (28): @babel/core, babel-plugin-react-compiler, date-fns, @emotion/react, @emotion/styled, eslint, eslint-config-prettier, @eslint/js (+20 more)

### Community 4 - "Clean Architecture fundamentals"
Cohesion: 0.11
Nodes (29): Incremental graph updates, Replace on reextract, Semantic cache manifest, Application use cases, Architecture tests, Clean Architecture, Clean Architecture fundamentals, Composition root (+21 more)

### Community 5 - "Graphify knowledge graph workflow"
Cohesion: 0.06
Nodes (35): Debounced code watcher, URL ingestion, URL ingestion and folder watching, Graph exports and benchmark, GraphRAG JSON, Interactive HTML graph, MCP graph server, Neo4j Cypher export (+27 more)

### Community 6 - "EventsHub.Application.UnitTests.csproj"
Cohesion: 0.06
Nodes (32): MediatR (14.2.0), Microsoft.AspNetCore.Mvc.NewtonsoftJson (10.0.11), Microsoft.AspNetCore.OpenApi (10.0.11), Microsoft.EntityFrameworkCore.Design (10.0.11), Microsoft.EntityFrameworkCore.Sqlite (10.0.11), Moq (4.20.72), Newtonsoft.Json (13.0.4), NSwag.AspNetCore (14.7.1) (+24 more)

### Community 7 - "EventsControllerTests"
Cohesion: 0.13
Nodes (19): ActionResult, HttpDelete, HttpPost, HttpPut, NoContentResult, OkResult, ProducesResponseType, ServiceProvider (+11 more)

### Community 8 - "compilerOptions"
Cohesion: 0.10
Nodes (19): compilerOptions, allowArbitraryExtensions, allowImportingTsExtensions, erasableSyntaxOnly, jsx, lib, module, moduleDetection (+11 more)

### Community 9 - "MapperTests"
Cohesion: 0.08
Nodes (38): ArgumentException, ArgumentNullException, InvalidOperationException, TestCase, IReadOnlyList, List, ChildDest, Name (+30 more)

### Community 10 - "devDependencies"
Cohesion: 0.10
Nodes (21): devDependencies, @babel/core, babel-plugin-react-compiler, eslint, eslint-config-prettier, @eslint/js, eslint-plugin-react-hooks, eslint-plugin-react-refresh (+13 more)

### Community 11 - "Event"
Cohesion: 0.12
Nodes (17): DateTimeOffset, Event, Category, City, Date, Description, Id, IsCancelled (+9 more)

### Community 12 - "compilerOptions"
Cohesion: 0.12
Nodes (16): compilerOptions, allowImportingTsExtensions, erasableSyntaxOnly, lib, module, moduleDetection, noEmit, noFallthroughCasesInSwitch (+8 more)

### Community 13 - "EventsHub architecture snapshot September 2026"
Cohesion: 0.09
Nodes (38): AppDbContext, Axios JSON requests, Coordinate contract mismatch, Event entity, EventsController, EventsHub architecture snapshot September 2026, Generated CSharp client, Historical application placeholder (+30 more)

### Community 14 - "Local baseUrl: https://localhost:5001/api/v1"
Cohesion: 0.29
Nodes (11): Local baseUrl: https://localhost:5001/api/v1, Create event: POST /events, asserts HTTP 200, Edit event: PUT /events, asserts HTTP 200, Event fixture 02ad363b-a2ba-4102-b98c-7a80745be581, Get existing event: GET /events/:eventId, asserts HTTP 200, Get missing event: GET /events/non-existing-eventId, asserts HTTP 404, List events: GET /events, asserts HTTP 200 and array, Events request folder (+3 more)

### Community 15 - "Part 4: npm only, `package.json` in a subfolder (Husky v9)"
Cohesion: 0.14
Nodes (14): Optional: add Prettier (code formatting), Part 4: npm only, `package.json` in a subfolder (Husky v9), Skipping hooks (use sparingly), Step 10: Setup for a new teammate or CI, Step 1: Check prerequisites, Step 2: Install Husky, Step 3: Point the `prepare` script at the subfolder, Step 4: Install the hooks (+6 more)

### Community 16 - "https"
Cohesion: 0.20
Nodes (9): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, profiles, https (+1 more)

### Community 17 - "EventsHub.OpenApi"
Cohesion: 0.22
Nodes (8): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, environmentVariables, launchBrowser, profiles, EventsHub.OpenApi, $schema

### Community 18 - "ActivityCard.tsx"
Cohesion: 0.31
Nodes (7): @mui/icons-material, react-calendar, ActivitiesDashboard(), ActivityCard(), Props, ActivityFilters(), ActivityList()

### Community 19 - "WeatherForecast"
Cohesion: 0.25
Nodes (7): EventsHub.API, DateOnly, WeatherForecast, Date, Summary, TemperatureC, TemperatureF

### Community 20 - "Git in practice"
Cohesion: 0.43
Nodes (8): Cherry pick, Git branches, Git commits, Git in practice, Merge, Pull requests, Squash, Stash

### Community 21 - "InitialCreate"
Cohesion: 0.20
Nodes (7): microsoft_entityframeworkcore_migrations, Migration, MigrationBuilder, DateTime, DateTime, ModelBuilder, InitialCreate

### Community 23 - "React + TypeScript + Vite template"
Cohesion: 0.40
Nodes (5): React + TypeScript + Vite template, React Compiler, Type-aware ESLint rules, @vitejs/plugin-react with Oxc, @vitejs/plugin-react-swc with SWC

### Community 24 - "Repository guidelines"
Cohesion: 0.50
Nodes (4): Bruno HTTP collections, Frontend build and lint, NUnit SQLite tests, Repository guidelines

### Community 25 - "Architecture documentation workflow"
Cohesion: 0.67
Nodes (3): Approved documentation outline, Architecture documentation workflow, Discovery before documentation

### Community 28 - "Part 1: .NET + npm in the same repo (e.g. EventsHub)"
Cohesion: 0.13
Nodes (15): Optional: add Prettier (code formatting), Part 1: .NET + npm in the same repo (e.g. EventsHub), Skipping hooks (use sparingly), Step 10: Commit the Husky files, Step 11: Setup for a new teammate or CI, Step 1: Check prerequisites, Step 2: Install Husky.Net as a local tool, Step 3: Install the Git hooks (+7 more)

### Community 29 - "Part 3: npm only, `package.json` in the repo root (Husky v9)"
Cohesion: 0.13
Nodes (15): Optional: add Prettier (code formatting), Part 3: npm only, `package.json` in the repo root (Husky v9), Skipping hooks (use sparingly), Step 10: Commit the Husky files, Step 11: Setup for a new teammate or CI, Step 1: Check prerequisites, Step 2: Make sure `package.json` and `.gitignore` exist, Step 3: Install Husky (+7 more)

### Community 30 - "dependencies"
Cohesion: 0.13
Nodes (15): dependencies, axios, date-fns, @emotion/react, @emotion/styled, @fontsource/roboto, @mui/icons-material, @mui/material (+7 more)

### Community 31 - "routes.tsx"
Cohesion: 0.20
Nodes (13): @fontsource/roboto, react, react-dom, react-router, @tanstack/react-query-devtools, App(), web_src_app_layout_index, NavBar() (+5 more)

### Community 34 - "openspec-explore/SKILL.md"
Cohesion: 0.17
Nodes (11): Check for context, Ending Discovery, Guardrails, Handling Different Entry Points, OpenSpec Awareness, Planning a Change, The Stance, What You Don't Have To Do (+3 more)

### Community 40 - "scripts"
Cohesion: 0.40
Nodes (5): scripts, build, dev, lint, preview

### Community 41 - "TypeMap"
Cohesion: 0.07
Nodes (29): IReadOnlyDictionary, LambdaExpression, MethodInfo, PropertyInfo, Action, Expression, Func, IMappingExpression (+21 more)

### Community 42 - "HandlerTestBase"
Cohesion: 0.08
Nodes (26): DbUpdateException, OperationCanceledException, SqliteConnection, Task, Test, CreateEventTests, Exception, Task (+18 more)

### Community 43 - "Mapper"
Cohesion: 0.12
Nodes (15): Assembly, Handler, IServiceCollection, IMapper, Dictionary, Type, Mapper, MappingProfiles (+7 more)

### Community 44 - "Domain"
Cohesion: 0.14
Nodes (13): EventsHub.Application.Events.Queries, Domain, IRequest, mediatr, Command, Event, CreateEvent, Command (+5 more)

### Community 45 - "EventsHub.Application.Core.Mapping"
Cohesion: 0.21
Nodes (7): EventsHub.Application.Core.Mapping, EventsHub.Application.UnitTests.Mapping, EventsHub.UnitTests.Controllers, EventsHub.Application.Core, microsoft_aspnetcore_http, microsoft_extensions_dependencyinjection, EventSummaryProfile

### Community 46 - "@mui/material"
Cohesion: 0.29
Nodes (9): @mui/material, ActivityDetailChat(), ActivityDetailHeader(), Props, ActivityDetailInfo(), Props, ActivityDetailPage(), ActivityDetailsSidebar() (+1 more)

### Community 47 - "Part 2: .NET only (Husky.Net)"
Cohesion: 0.14
Nodes (14): Part 2: .NET only (Husky.Net), Skipping hooks (use sparingly), Step 10: Commit the Husky files, Step 11: Setup for a new teammate or CI, Step 1: Check prerequisites, Step 2: Create a local tool manifest, Step 3: Install Husky as a local tool, Step 4: Install the Git hooks (+6 more)

### Community 48 - "Persistence"
Cohesion: 0.27
Nodes (8): EventsHub.Persistence.Migrations, Persistence, EventsHub.UnitTests, microsoft_data_sqlite, microsoft_entityframeworkcore, microsoft_entityframeworkcore_infrastructure, microsoft_entityframeworkcore_storage_valueconversion, system

### Community 49 - "EventsHub.Application.Events.Commands"
Cohesion: 0.25
Nodes (5): EventsHub.Application.UnitTests.Events, EventsHub.Application.Events.Commands, Command, Id, DeleteEvent

### Community 50 - "useActivities.tsx"
Cohesion: 0.31
Nodes (5): axios, @tanstack/react-query, ActivityForm(), agent, useActivities()

### Community 51 - "AppDbContextModelSnapshot"
Cohesion: 0.40
Nodes (4): ModelSnapshot, DateTime, ModelBuilder, AppDbContextModelSnapshot

### Community 52 - "husky-setup.md"
Cohesion: 0.50
Nodes (3): How to use this guide, Installing Husky in a Project: .NET and npm, Where to run the commands (read this once)

### Community 56 - "lint-staged"
Cohesion: 0.67
Nodes (3): lint-staged, *.{json,md,css}, *.{ts,tsx}

## Knowledge Gaps
- **318 isolated node(s):** `$schema`, `tasks`, `Mediator`, `net10.0`, `Microsoft.AspNetCore.OpenApi (10.0.11)` (+313 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 415 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **17 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `Mapper` connect `Mapper` to `TypeMap`, `EventsHub.Application.Core.Mapping`, `MapperTests`?**
  _High betweenness centrality (0.033) - this node is a cross-community bridge._
- **Why does `Event` connect `Event` to `HandlerTestBase`, `Mapper`, `Domain`, `EventsControllerTests`?**
  _High betweenness centrality (0.030) - this node is a cross-community bridge._
- **Why does `EventsHub.Application.Core.Mapping` connect `EventsHub.Application.Core.Mapping` to `TypeMap`, `Mapper`, `Domain`, `MapperTests`?**
  _High betweenness centrality (0.030) - this node is a cross-community bridge._
- **What connects `$schema`, `tasks`, `Mediator` to the rest of the system?**
  _318 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `EventsRpcClient` be split into smaller, more focused modules?**
  _Cohesion score 0.07373271889400922 - nodes in this community are weakly interconnected._
- **Should `EventsController.cs` be split into smaller, more focused modules?**
  _Cohesion score 0.13970588235294118 - nodes in this community are weakly interconnected._
- **Should `Event` be split into smaller, more focused modules?**
  _Cohesion score 0.0563265306122449 - nodes in this community are weakly interconnected._