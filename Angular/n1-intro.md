<h2 align="center"> Angular intro</h2>



- Installation:
  - npm i -g @angular/cli //install CLI
  - ng new AngularApp //create a new project
  - ng serve //live streaming
  - npm i bootstrap jquery popper --save  //install other dependencies
  

- Angular: single page application using Typescript
  - TS: Js with strongly data type
  - module-based 
  - module: basic block 
  - to create module: use decorator @Ngmodule({})
  
- component: the small block used by the modules
  - a TS class with @component decorator
  - an html file particulat to the component (template)
  - a style file (css/scss)
  - a TS file tp write unit test (spec.ts)



- Directives: 
  - Components: directives with a template
  - Attribute: change appearance or behavior of a particular elem
  - Structural directives: change layout of elem, create/destroy/show/hide
    - *ngIf, *ngFor, *ngSwitch
    
```
 <tr *ngFor="let p of products">
            <td>{{p.id}}</td>
            <td>{{p.name}}</td>
            <td>{{p.UnitPrice}}</td>
</tr>

<div *ngIf="condition; then thenBlock else elseBlock"></div>
<ng-template #thenBlock>Content to render when condition is true.</ng-template>
<ng-template #elseBlock>Content to render when condition is false.</ng-template>


```

- interpolation: {{}}
  - variables in app.component.ts -> app.component.html
  - pipe:
    - {{birthday | date}}   


- what is diff btw AoT(ahead iof time) and JiT (just in time) compiler?
  - AoT: compile the application at build time 
  - JiT: compile at run time
  - AoT runs faster then JiT

