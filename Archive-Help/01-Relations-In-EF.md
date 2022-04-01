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
 

HasMany(`Child`).WithMany() = Many to Many

HasMany(`Child`).WithOptional(`Parent`) = One to Many -> The Child can Have Parent(Like Comments of instagram)

HasMany(`Child`).WithRequired(`Parent`) = One to Many -> The Child Must Have Parent(Like Provience and City)