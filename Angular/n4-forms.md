<h2 align='center'> Template Driven Forms VS. Reactive Forms </h2>

Template Driven Forms 
- static forms
- FormModule in the module file
- [(NgModel)] for two way binding
- template reference variables inside the form
- need to focus firstly on the HTML page

<hr>

Reactive Forms
- dynamic forms
- ReactiveFormModule 
- FormGroup
- FormControl
- FormBuilder
- easy to validation

<hr>

Angular Validators

<hr>

1. Service: call data from API and pass data to components
2. @input and @output 
3. behavior subject

<hr>

Promises Vs. Observables
- Promises: deal with one asynchronous event at a time
- Observables: handle a sequence of asynchronous events over a period of time
- observables better than promises, with more functionalities
<table>
  <tr>
    <td>Promises</td>
    <td> Observables</td>
  </tr>
  <tr>
    <td>Emit a single value at a time.</td>
    <td> Emit multiple values over a period of time.</td>
  </tr>
  
  <tr>
    <td>are not lazy: execute immediately after creation</td>
    <td>Lazy: not executed until subscribe()</td>
  </tr>
  
  <tr>
    <td>are not cancellable</td>
    <td>unsubscribe() to cancel, stop the listener from receiving further values</td>
  </tr>
  
  <tr>
    <td>don't provide any operations</td>
    <td>provide the map for forEach, filter, reduce, retry, and retryWhen operators</td>
  </tr>
  
  <tr>
    <td>push errors to the child promises</td>
    <td>deliver errors to the subscribers</td>
  </tr>
</table>
