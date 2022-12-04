import { Component } from '@angular/core';
import {AbstractControl, FormArray, FormBuilder, FormGroup, Validators} from "@angular/forms";
import {COMMA, ENTER} from "@angular/cdk/keycodes";
import {MatChipEditedEvent, MatChipInputEvent} from "@angular/material/chips";
import {SocialMediaPlatform, UserSocialProfileService} from "../../libs/api-client";

@Component({
  selector: 'app-user-social-profile-form',
  templateUrl: './user-social-profile-form.component.html',
  styleUrls: ['./user-social-profile-form.component.css']
})
export class UserSocialProfileFormComponent {
  public userSocialProfileForm: FormGroup;
  public socialMediaPlatforms: string[] = [];
  public serverResponse: string = '';
  public addOnBlur = true;
  readonly separatorKeysCodes = [ENTER, COMMA] as const;
  constructor(
              private fb: FormBuilder,
              private userSocialProfileService: UserSocialProfileService) {
    this.userSocialProfileForm = this.fb.group({
      lastName: ['' ],
      firstName: ['', [Validators.required]],
      socialSkills: [[]],
      socialMediaAccounts: this.fb.array([])
    });

    for (let socialMediaPlatformKey in SocialMediaPlatform) {
      this.socialMediaPlatforms.push(socialMediaPlatformKey)
    }
  }

  ngOnInit() {
  }

  submit(value: any){
    const dto = {...value}
    this.userSocialProfileService.userSocialProfileCreate(dto)
      .subscribe(response => {
          this.serverResponse = JSON.stringify(response, null, '\t');
      },
      error => {
       console.log(error)
      })
  }

  get accounts() {
    return this.userSocialProfileForm.controls['socialMediaAccounts'] as FormArray
  }

  addSocialMediaAccount() {
    const socialMediaAccountForm = this.fb.group({
      user: ['', [Validators.required, Validators.minLength(1)]],
      socialMediaPlatform: [1, Validators.required]
    });

    this.accounts.push(socialMediaAccountForm);
  }

  deleteAccount(index: number) {
    this.accounts.removeAt(index);
  }

  castControlToGroup(accountForm: AbstractControl<any>): FormGroup {
    return accountForm as FormGroup;
  }

  get socialSkills(){
    return this.userSocialProfileForm.controls['socialSkills'].value
  }

  add(event: MatChipInputEvent): void {
    const value = (event.value || '').trim();

    if (value) {
      this.socialSkills.push(value);
    }

    event.chipInput!.clear();
  }

  remove(socialSkill: string): void {
    const index = this.socialSkills.indexOf(socialSkill);

    if (index >= 0) {
      this.socialSkills.splice(index, 1);
    }
  }

  edit(socialSkills: string, event: MatChipEditedEvent) {
    const value = event.value.trim();

    if (!value) {
      this.remove(socialSkills);
      return;
    }

    const index = this.socialSkills.indexOf(socialSkills);
    if (index > 0) {
      this.socialSkills[index]= value;
    }
  }

}
