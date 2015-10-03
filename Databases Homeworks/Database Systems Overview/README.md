#### 1. What database models do you know?

A database model is a type of data model that determines the logical structure of a database and fundamentally determines in which manner data can be stored, organized, and manipulated. The most popular example of a database model is the relational model, which uses a table-based format.

- **Hierarchical database model** - A hierarchical database model is a data model in which the data is organized into a tree-like structure. The data is stored as records which are connected to one another through links. A record is a collection of fields, with each field containing only one value. The entity type of a record defines which fields the record contains.
 
- **Network model** - The network model is a database model conceived as a flexible way of representing objects and their relationships. Its distinguishing feature is that the schema, viewed as a graph in which object types are nodes and relationship types are arcs, is not restricted to being a hierarchy or lattice.
 
- **Network model** - The network model is a database model conceived as a flexible way of representing objects and their relationships. Its distinguishing feature is that the schema, viewed as a graph in which object types are nodes and relationship types are arcs, is not restricted to being a hierarchy or lattice.
 
- **Relational model** - In the relational model of a database, all data is represented in terms of tuples, grouped into relations. A database organized in terms of the relational model is a relational database.The purpose of the relational model is to provide a declarative method for specifying data and queries: users directly state what information the database contains and what information they want from it, and let the database management system software take care of describing data structures for storing the data and retrieval procedures for answering queries.
 
- **Object-oriented model** - An object database (also object-oriented database management system) is a database management system in which information is represented in the form of objects as used in object-oriented programming. Object databases are different from relational databases which are table-oriented. Object-relational databases are a hybrid of both approaches.
 
#### 2. Which are the main functions performed by a Relational Database Management System (RDBMS)?

A relational DBMS is special system software that is used to: 

- manage the organization
- storage
- access
- security
- integrity of data

This specialized software allows application systems to focus on the user interface, data validation and screen navigation.  When there is a need to: 

- add
- modify
- delete
- display data

#### 3. Define what is "table" in database terms.

A table is a collection of related data held in a structured format within a database into rows and columns. It can be used to both store and display data in a structured format. For example, databases store data in tables so that information can be quickly accessed from specific rows.
 
In relational databases and flat file databases, a table is a set of data elements. A table has a specified number of columns, but can have any number of rows.Each row is identified by one or more values appearing in a particular column subset. The columns subset which uniquely identifies a row is called the primary key.The table is another term for "relation" in RDBMS.

#### 4. Explain the different kinds of relationships between tables in relational databases.

* **One to One Relationships** - Both tables can have only one record on either side of the relationship. Each primary key value relates to only one (or no) record in the related table. They're like spouses—you may or may not be married, but if you are, both you and your spouse have only one spouse. Most one-to-one relationships are forced by business rules and don't flow naturally from the data. In the absence of such a rule, you can usually combine both tables into one table without breaking any normalization rules.

* **One to Many and Many to One Relationships** - The primary key table contains only one record that relates to none, one, or many records in the related table. This relationship is similar to the one between child and a parent.The child has only one mother, but the mother may have several children.

* **Many to Many Relationships** - Each record in both tables can relate to any number of records (or no records) in the other table. For instance, if you have several siblings, so do your siblings (have many siblings). Many-to-many relationships require a third table, known as an associate or linking table, because relational systems can't directly accommodate the relationship.

#### 5. Explain the difference between a primary and a foreign key.

* **Primary Key**
	- Primary key uniquely identify a record in the table.
	- Primary Key can't accept null values.
	- By default, Primary key is clustered index and data in the database table is physically organized in the sequence of clustered index.
	- We can have only one Primary key in a table.

* **Foreign Key**
	- Foreign key is a field in the table that is primary key in another table.
	- Foreign key can accept multiple null value.
	- Foreign key do not automatically create an index, clustered or non-clustered. You can manually create an index on foreign key.
	- You can have more than one foreign key in a table.

#### 6. When is a certain database schema normalized? What are the advantages of normalized databases?

Normalization is the process of removing redundant data from your tables in order to improve storage efficiency, data integrity and scalability. This improvement is balanced against an increase in complexity and potential performance losses from the joining of the normalized tables at query-time. There are two goals of the normalization process: eliminating redundant data (for example, storing the same data in more than one table) and ensuring data dependencies make sense (only storing related data in a table). Both of these are worthy goals as they reduce the amount of space a database consumes and ensure that data is logically stored.

**Advantages of normalization:**

* More efficient data structure.
* Avoid redundant fields or columns.
* More flexible data structure i.e. we should be able to add new rows and data values easily
* Better understanding of data.
* Ensures that distinct tables exist when necessary.
* Easier to maintain data structure i.e. it is easy to perform operations and complex queries can be easily handled.
* Minimizes data duplication.
* Close modeling of real world entities, processes and their relationships.

#### 7. What are database integrity constraints and when are they used?

Data integrity refers to maintaining and assuring the accuracy and consistency of data over its entire life-cycle, and is a critical aspect to the design, implementation and usage of any system which stores, processes, or retrieves data. The term data integrity is broad in scope and may have widely different meanings depending on the specific context.

**Types of Integrity Constraints:**

* **Entity integrity** concerns the concept of a primary key. Entity integrity is an integrity rule which states that every table must have a primary key and that the column or columns chosen to be the primary key should be unique and not null.

* **Referential integrity** concerns the concept of a foreign key. The referential integrity rule states that any foreign-key value can only be in one of two states. The usual state of affairs is that the foreign-key value refers to a primary key value of some table in the database. Occasionally, and this will depend on the rules of the data owner, a foreign-key value can be null. In this case we are explicitly saying that either there is no relationship between the objects represented in the database or that this relationship is unknown.

* **Domain integrity** specifies that all columns in a relational database must be declared upon a defined domain. The primary unit of data in the relational data model is the data item. Such data items are said to be non-decomposable or atomic. A domain is a set of values of the same type. Domains are therefore pools of values from which actual values appearing in the columns of a table are drawn.

#### 8. Point out the pros and cons of using indexes in a database.

**Advantages:**

* Index is used for quick access to a database table specific information. The index is a structure of the database table the value of one or more columns to sort
As a general rule, only when the data in the index column Frequent queries, only need to create an index on the table. The index take up disk space and reduce to add, delete, and update the line speed. In most cases, the speed advantages of indexes for data retrieval greatly exceeds it. Database indices are based on a data structure  B-tree to improve the search speed.

**Disadvantages:**

* Too much indices will affect the speed of update and insert, because it requires the same update each index file. For a frequently updated and inserted into the table, there is no need for a rarely used where the words indexed separately, small table, the cost of sorting will not be great, there is no need to create additional indexes. In some cases, the indexing words may not be fast, for example, the index is placed in a contiguous memory space, which will increase the burden of disk read, which is optimal, it should be through the actual use of the environment to be tested.
 
#### 9. What's the main purpose of the SQL language?

SQL stands for Structured Query Language. SQL is used to communicate with a database. It is standart language for relational database management systems developed by Microsoft. SQL statements are used to perform tasks such as update data on a database, or retrieve data from a database. Some common relational database management systems that use SQL are: Oracle, Sybase, Microsoft SQL Server, Access. Although most database systems use SQL, most of them also have their own additional proprietary extensions that are usually only used on their system. However, the standard SQL commands such as "SELECT", "INSERT", "Update", "DELETE", "CREATE" and "DROP" can be used to accomplish almost everything that one needs to do with a database.
 
#### 10. What are transactions used for? Give an example.

A transaction is a unit of work that is performed against a database. Transactions are units or sequences of work accomplished in a logical order, whether in a manual fashion by a user or automatically by some sort of a database program. SQL queries will club into a group and then we execute all of them together as a part of a transaction.

**Transaction Commands:**

* **COMMIT** - this is the transactional command used to save changes invoked by a transaction to the database. It saves all transactions to the database since the last COMMIT or ROLLBACK command.

* **ROLLBACK** - this command is the transactional command used to undo transactions that have not already been saved to the database. It can only be used to undo transactions since the last COMMIT or ROLLBACK command was issued.

**Example:**

```
SQL
BEGIN TRAN 

UPDATE authors 
SET	au_fname = 'John' 
WHERE	au_id = '172-32-1176' 

UPDATE authors 
SET	au_fname = 'JohnY' 
WHERE	city = 'Lawrence' 

IF @@ROWCOUNT = 5 
  COMMIT TRAN 
ELSE 
  ROLLBACK TRAN 
```

#### 11. What is a NoSQL database?

A NoSQL ("non SQL" or "not only SQL") database provides a mechanism for storage and retrieval of data that is modeled in means other than the tabular relations used in relational databases. NoSQL databases are increasingly used in big data and real-time web applications.

They are used because of simplicity of their design, simpler "horizontal" scaling to clusters of machines, which is a problem for relational databases, and finer control over availability. The data structures used by NoSQL databases (e.g. key-value, graph, or document) differ slightly from those used by default in relational databases, making some operations faster in NoSQL and others faster in relational databases. The particular suitability of a given NoSQL database depends on the problem it must solve. Sometimes the data structures used by noSQL databases are also viewed as "more flexible" than relational database tables.

#### 12. Explain the classical non-relational data models.

* **Document model** 

	- The central concept of a document model is the notion of a "document". While each document-oriented database implementation differs on the details of this definition, in general, they all assume that documents encapsulate and encode data (or information) in some standard formats or encodings. Encodings in use include XML, YAML, and JSON as well as binary forms like BSON. 

	- Documents are addressed in the database via a unique key that represents that document. One of the other defining characteristics of a document-oriented database is that in addition to the key lookup performed by a key-value store, the database offers an API or query language that retrieves documents based on their contents.

	- Compared to relational databases, for example, collections could be considered analogous to tables and documents analogous to records. But they are different: every record in a table has the same sequence of fields, while documents in a collection may have fields that are completely different.

	- Examples: MongoDB, CouchDB, etc.

* **Key-value model** 
	- Key-value model use the associative array (a.k.a. Dictionary in C#) as their fundamental data model. In this model, data is represented as a collection of key-value pairs, such that each possible key appears at most once in the collection.

	- The Key-value model is one of the simplest non-trivial data models, and richer data models are often implemented on top of it. The key-value model can be extended to an ordered model that maintains keys in lexicographic order. This extension is powerful, in that it can efficiently process key ranges.

	- Key-value model can use consistency models ranging from eventual consistency to serializability. Some support ordering of keys. Some maintain data in memory (RAM), while others employ solid-state drives or rotating disks.

	- Examples: Oracle NoSQL Database, Redis, etc.

* **Hierarchical key-value model** 

	- This data model allows elements to link and be linked by several other elements thus constructing a hierarchical structure. Links usually have additional properties to describe the relation between elements.

* **Wide-column model**

	- Wide-column model takes a hybrid approach mixing the declarative characteristics game of relational databases with the key-value pair based and totally variables schema of key-value stores. Wide Column databases stores data tables as sections of columns of data rather than as rows of data.

	- Examples: Cassandra, HBase, Vertica, etc.

* **Object model**

	- Object-oriented database management systems (OODBMSs) combine database capabilities with object-oriented programming language capabilities. They allow object-oriented programmers to develop the product, store them as objects, and replicate or modify existing objects to make new objects within the OODBMS. Because the database is integrated with the programming language, the programmer can maintain consistency within one environment, in that both the OODBMS and the programming language will use the same model of representation.

	- Some object-oriented databases are designed to work well with object-oriented programming languages such as Delphi, Ruby, Python, Perl, Java, C#, Visual Basic .NET, C++, Objective-C.

	- Examples: Cache, Perst, Shoal, etc.

#### 13. Give few examples of NoSQL databases and their pros and cons.

* **MongoDB**

	* **Pros**

		* Schema-less. If you have a flexible schema, this is ideal for a document store like MongoDB. This is difficult to implement in a performant manner in RDBMS.
		* Ease of scale-out. Scale reads by using replica sets. Scale writes by using sharding (auto balancing).
		* Cost. MongoDB is free and can run on Linux.
		* You can choose what level of consistency you want depending on the value of the data.

	* **Cons**

		* Data size in MongoDB is typically higher due to e.g. each document has field names stored it.
		* Less flexibility with querying.
		* No support for transactions - certain atomic operations are supported, at a single document level.
		* Less up to date information available/fast evolving product.

* **Redis**

	* **Pros**

		* Stores data in a variety of formats: list, array, sets and sorted sets.
		* Multiple commands at once.
		* Blocking reads - it will wait until another process writes data to the cache.
		* Mass insertion of data to prime a cache.
		* Partitions data across multiple redis instances.
		* Can back data to disk.

	* **Cons**

		* Super complex to configure - requires consideration of data size to configure well.
		* Lots of server administration for monitoring and partitioning and balancing. 

* **Cassandra**

	* **Pros**

		* Cassandra is solving the problem of distributed and scalable systems, and it's built to cope with data management challenges of modern business.
		* Cassandra is decentralized system - there is no single point of failure, if minimum required setup for cluster is present - every node in the cluster has the same role, and every node can service any request. Replication strategies can be configured. It is possible to add new nodes to server cluster very easy. Also, if one node fails, data can be retrieved from some of the other nodes (redundancy can be tuned). It is especially suitable for multiple data-center deployment, redundancy, failover and disaster recovery, with possibility of replication across multiple data centers.

	* **Cons**

		* There is no referential integrity - there is no concept of JOIN connections in Cassandra.
		* Querying options for retrieving data are very limited.
		* There is no things like ORDER BY, GROUP BY.