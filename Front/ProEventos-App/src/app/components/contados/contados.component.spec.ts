/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { ContadosComponent } from './contados.component';

describe('ContadosComponent', () => {
  let component: ContadosComponent;
  let fixture: ComponentFixture<ContadosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ContadosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ContadosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
