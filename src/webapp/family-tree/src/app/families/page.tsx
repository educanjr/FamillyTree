import { DropdownOption } from '@/Interfaces/DropdownOption';
import DropdownSelect from '@/componets/dropdown/dropdown-select';

const apiUrl = 'http://localhost:7006/api/v1/Families';

export default async function Families() {
    let options: DropdownOption[] = [];
    try {
        const response = await fetch(apiUrl);
        options = await response.json();
    } catch (error) {
        console.error("Error fetching dropdown options:", error);
    }
    
    return (
        <DropdownSelect options={options}/>
    );
}