import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrls: ['./forms.component.css']
})
export class FormsComponent {
  
  selectedTab = 'template';

  // Template-driven form
  templateEmail: string = '';

  // Reactive form
  reactiveForm!: FormGroup;

  constructor(private fb: FormBuilder) {}

  ngOnInit(): void {
    this.reactiveForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]]
    });
  }

  submitTemplateForm(form: any) {
    if (form.valid) {
      alert(`Template-driven Email: ${this.templateEmail}`);
    }
  }

  submitReactiveForm() {
    if (this.reactiveForm.valid) {
      alert(`Reactive Form Email: ${this.reactiveForm.value.email}`);
    }
  }
}
