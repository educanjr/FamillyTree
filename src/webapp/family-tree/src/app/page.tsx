import { fetchFamilies } from "@/api-queries/fetchFamilies";
import FamilySelector from "@/componets/family-selector/family-selector";
import {DropdownOption} from "@/Interfaces/dropdownOption";

export default async function HomePage() {
  const options: DropdownOption[] = [];
  try {
    const families = await fetchFamilies();
    if (families && families.families){
        options.push(...families.families.map(item => ({
            label: item.name,
            value: item.id,
        })));
    }
  } catch (error) {
    console.error("Error fetching dropdown options:", error);
  }
  
  return (
    <>
        <FamilySelector options={options}/>
    </>
  );
}
