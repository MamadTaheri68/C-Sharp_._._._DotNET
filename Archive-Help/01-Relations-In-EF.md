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