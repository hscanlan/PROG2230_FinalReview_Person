# Final Practice Exam PROG2230: Refactoring and Testing Person Management Project

**Total Marks:** 30  
**Duration:** 2 Hours  

---

## Instructions

1. Refactor the project to introduce a `PersonService` class that encapsulates all CRUD operations for the `Person` entity.  
2. Write unit tests using xUnit to validate the functionality of the `PersonService` class.  
3. Submit your solution as a zip file containing your refactored project and test cases.  

---

## Exam Sections

### Section A: Refactoring for Testability (10 Marks)

Refactor the project to encapsulate all business logic for `Person` into a new `PersonService` class.

#### Tasks:

1. **Create a `PersonService` Class (5 Marks)**  
   - Create a new class in the main project called `PersonService`.  
   - Implement CRUD operations (`AddPerson`, `GetPersonById`, `UpdatePerson`, `DeletePerson`) in `PersonService`.  
   - Use `PersonContext` for database operations.  

2. **Integrate `PersonService` into the Project (5 Marks)**  
   - Refactor the existing code (if necessary) to use the new `PersonService` class for all `Person`-related operations.

#### Deliverable:  
- A fully implemented `PersonService` class containing CRUD logic.  
- Ensure the application builds and runs without errors after refactoring.  

---

### Section B: Unit Testing `PersonService` (20 Marks)

Write unit tests using xUnit to validate the functionality of the `PersonService` class.

#### Tasks:

1. **Test `AddPerson` Method (5 Marks)**  
   - Verify that a new person is successfully added to the database.  

2. **Test `GetPersonById` Method (5 Marks)**  
   - Verify that a person is retrieved correctly by their ID.  
   - Verify that `null` is returned for a non-existent ID.  

3. **Test `UpdatePerson` Method (5 Marks)**  
   - Verify that a person’s details are updated correctly in the database.  
   - Verify that properties not updated remain unchanged.  

4. **Test `DeletePerson` Method (5 Marks)**  
   - Verify that a person is removed from the database when a valid ID is provided.  
   - Verify that attempting to delete a non-existent person does not throw an error.  

#### Deliverable:  
- A test project containing xUnit tests for the `PersonService` class.  
- Use `InMemoryDatabase` from `Microsoft.EntityFrameworkCore` to mock the database context and avoid reliance on an actual database.  

---

## Marking Rubric

| **Criteria**            | **Marks** | **Description**                                                             |
|--------------------------|-----------|-----------------------------------------------------------------------------|
| `PersonService` Implementation | 10        | A fully implemented `PersonService` class with CRUD operations.             |
| `AddPerson` Tests        | 5         | xUnit tests to verify adding a new person to the database.                   |
| `GetPersonById` Tests    | 5         | xUnit tests to verify retrieving a person by ID, including non-existent IDs. |
| `UpdatePerson` Tests     | 5         | xUnit tests to verify updating a person’s details and preserving unchanged data. |
| `DeletePerson` Tests     | 5         | xUnit tests to verify removing a person from the database and handling errors. |

---

## Submission Guidelines

- Include your refactored project files.  
- Include a separate project folder for xUnit tests.  
- Submit your work in a zip file.  
