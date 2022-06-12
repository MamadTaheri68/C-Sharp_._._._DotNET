<div dir="auto" align="right">
   <h1> انواع روابط </h1>
</div>

<div dir="auto" align="right">
   <ul>
      <li>رابطه یک به یک </li>
      <li>رابطه یک به چند</li>
      <li>رابطه چند به چند</li>
   </ul>
</div>
 
* One to One
   
   HasOne(`Child`).WithOne()  

* One to Many -> The Child has Optional Parent(Like Comments of instagram)

   HasMany(`Child`).WithOptional(`Parent`)

* One to Many -> The Child has Required Parent(Like Provience and City)

   HasMany(`Child`).WithRequired(`Parent`)

* Many to Many 

   HasMany(`Child`).WithMany()


## More Info Based on Microsoft Docs

* ### HasOptional Method
  
   Configures an `optional` relationship from this entity type. Instances of the entity type will be able to be saved to the database without this relationship being specified. The foreign key in the database will be `nullable`.

* ### HasRequired Method
  
   Configures a `required` relationship from this entity type. Instances of the entity type will not be able to be saved to the database unless this relationship is specified. The foreign key in the database will be `non-nullable`.

* ### HasMany Method
  
   Configures a `many relationship` from this entity type.