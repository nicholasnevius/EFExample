
# Animal_Owners Table

| Animal_ID | Owner_ID |
|-----------|----------|
| 1         | 1        |
| 1         | 2        |
| 2         | 1        |

ANIMAL_ID : INT Foreign Key
OWNER_ID  : INT Foreign Key


# Animals Table

| ID | Name     | Species |
|----|----------|---------|
| 1  | Sparky   | 2       |
| 2  | Not Nick | 1       |

ID      : INT Primary Key
Name    : VARCHAR(50)
SPECIES : INT


# Owners Table

| ID | Name          |
|----|---------------|
| 1  | Nick          |
| 2  | Not Nick      |
| 3  | Also Not Nick |

ID   : INT Primary Key
Name : VARCHAR(50)


# Main() output

    Sparky is owned by:
    Nick
    Not Nick
    Nick owns:
    Sparky
    Whiskers