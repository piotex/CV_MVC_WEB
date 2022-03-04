import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdEditInspectionComponent } from './ad-edit-inspection.component';

describe('AdEditInspectionComponent', () => {
  let component: AdEditInspectionComponent;
  let fixture: ComponentFixture<AdEditInspectionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdEditInspectionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdEditInspectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
