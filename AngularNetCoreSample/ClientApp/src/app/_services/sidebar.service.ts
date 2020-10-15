import { Injectable } from '@angular/core';

@Injectable({
	providedIn: 'root'
})
export class SidebarService {

	public sidebarVisible: boolean = true;

	constructor() { }


	getStatus() {
		return this.sidebarVisible;
	}
}
