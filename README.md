## W12_CodeFirstRelation

This project demonstrates the **Code First** approach using **Entity Framework Core**. It implements a simple database structure with users and their associated posts, highlighting a one-to-many relationship between users and posts.

### Project Details

- **Context Class:** `PatikaSecondDbContext`
- **Database Name:** `PatikaCodeFirstDb2`
- **Tables:** `Users` and `Posts`

### Tables Overview

#### 1. `Users` Table
- **Id** (int): Primary key, auto-incremented.
- **Username** (string): User's username.
- **Email** (string): User's email address.

#### 2. `Posts` Table
- **Id** (int): Primary key, auto-incremented.
- **Title** (string): Title of the post.
- **Content** (string): Content of the post.
- **UserId** (int): Foreign key referencing the `Users` table. Defines the relationship between users and their posts.

### Entity Relationship
- A **User** can have multiple **Posts**.
- Each **Post** belongs to exactly one **User**.