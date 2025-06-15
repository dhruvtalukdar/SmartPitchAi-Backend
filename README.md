Design Patterns that has been been used in the codebase


---

## 🎯 Design Patterns Used

### ✅ Clean Architecture / Onion Architecture
- **Evidence:**
  - `Domain/`: Business Entities, Interfaces
  - `Application/`: Use Cases, DTOs
  - `Infrastructure/`: EF Core, Services
  - `API/`: Controllers and route handling

- **Explanation:**
  - Separates concerns by enforcing inward dependencies.
  - Business logic is completely isolated from frameworks and UI.

---

### ✅ Repository Pattern
- **Evidence:**
  - `Persistence/Repositories/`
  - `Domain/Interfaces/I[Entity]Repository.cs`

- **Explanation:**
  - Abstracts the data access logic.
  - Enables testing and mocking without depending on EF Core directly.

---

### ✅ Service / Use Case Pattern
- **Evidence:**
  - `Application/Services/`
  - `Application/UseCases/`

- **Explanation:**
  - Each class encapsulates a single use case (e.g., `LoginUserService`, `GenerateReportService`).
  - Separates orchestration from API and domain layers.

---

### ✅ Mediator Pattern *(Optional if using MediatR)*
- **Evidence:**
  - Usage of `IMediator.Send(...)` in API Controllers
  - Commands and Queries in Application layer

- **Explanation:**
  - Centralizes request/response logic.
  - Decouples controllers from business logic implementations.

---

## 🚀 Getting Started

1. **Clone the Repo**
   ```bash
   git clone https://github.com/your-org/SmartPitchAi-Backend.git
   cd SmartPitchAi-Backend

