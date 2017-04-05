https://www.infragistics.com/community/blogs/dhananjay_kumar/archive/2015/10/21/how-to-create-relationships-between-entities-in-the-entity-framework-code-first-approach.aspx
============================================================================
One to One Relationship

We may have a requirement to create one to one relationships between two entities. In other words, we need a Primary key – Foreign Key relationship between two entities. Let us say we have two entities and the following rules:

1.      There are two entities named Student and StudentAccount
2.      Student is a primary entity
3.     StudentAccount is a dependent entity on Student
4.     Primary key of StudentAccount will be foreign key of Student

We should not able to create a StudentAccount without a Student and there can only be one entry of Student in StudentAccount. Put simply, each Student will have one StudentAccount and no StudentAccount will exist without a Student.
==============================================================================

One to Many Relationship

We may have a requirement to create one too many relationship between two entities. Let us say we have two entities

1.      There are two entities Student and StudentAddress
2.      Student is a primary entity
3.     StudentAddress is a dependent entity on Student
4.     One Student can enroll in multiple StudentAddress

One Student can have many StudentAddress. One of the column of StudentAddress will have foreign key as primary key of Student.